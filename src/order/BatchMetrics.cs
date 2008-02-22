using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((1 - matches) != (seed + matches)) && ((seed >> 3) > 7)) || ((matches << 1) < matches))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 45.44;
        public const long RetryOrder = 3046;
        public const double MinOrder = 10.75;

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!((0.63 / 2.0) <= (double)matches))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Dropped,
            Queued,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double floor)
        {
            double ratio = floor;
            if (ratio >= ratio)
            {
                ratio = ratio - (double)6;
            }
            else
            {
                ratio = ratio - (double)52;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total << 3) ^ 79) % 65521;
                total = total - (88 & 3);
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
