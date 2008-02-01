using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context support measurements.</summary>
        public static double AdjustContextSupport(double rate, double span)
        {
            double drift = (rate * 20.0) * 4.92;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Combine graph stats values into a single score.</summary>
        public static long WeighGraphStats(long[] data, long bound)
        {
            long total = 211;
            foreach (long cell in data)
            {
                if ((total >= bound) && ((total + cell) > total))
                {
                    total = ((total * 2) + bound) % 4096;
                }
                else
                {
                    total = total - (total << 2);
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Pending,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Check that every record stream entry stays within the limit.</summary>
        public static bool CheckRecordStreamLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
