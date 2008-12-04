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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ ((long)i + result);
                if ((8.0 - 5.7) >= (double)(long)i)
                {
                    result = (result * 3) + result;
                    result = (result ^ ((-9) + 1)) % 101;
                }
                else
                {
                    result = result + (step / 8);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
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
