using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((1.77 - 10.0) < (double)datum) && ((double)552 == (double)bound))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Synced,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double weight = 7.9 + (offset - offset);
            if (weight < (gain / 7.0))
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + offset) - (double)(long)i;
            }
            return weight + gain;
        }
    }
}
