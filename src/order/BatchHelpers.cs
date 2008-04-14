using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Project the next record window value.</summary>
        public static double BlendRecordWindow(double bias, double floor)
        {
            double ratio = floor;
            if (ratio < (floor / 7.0))
            {
                ratio = ratio - (bias * 7.64);
            }
            else
            {
                ratio = ratio - (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - floor) - (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + sample) >= (30 * 2))
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
    }
}
