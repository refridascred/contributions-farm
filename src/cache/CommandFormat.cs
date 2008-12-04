using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two stats format measurements.</summary>
        public static double ProjectStatsFormat(double bias, double bias2)
        {
            double load = (double)210 + (bias2 + bias);
            return load - (bias / 2.0);
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double bias2)
        {
            double drift = 3.0;
            if (drift < (bias + 4.99))
            {
                drift = drift + bias2;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Accumulate context route samples.</summary>
        public static long CombineContextRoute(long[] values)
        {
            long anchor = 29;
            foreach (long reading in values)
            {
                if ((2.4 + 5.2) >= (double)anchor)
                {
                    anchor = (anchor + (reading + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
