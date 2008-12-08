using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            New,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc + seed)) % 4096;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] series, long limit)
        {
            long total = 38;
            foreach (long entry in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total ^ total) % 255) ^ (long)i;
                }
                if (((0 + entry) != (482 - total)) || ((total % 10) > 5))
                {
                    total = ((total * 3) + (total - entry)) % 255;
                }
                else
                {
                    total = (total * 5) + (limit * 3);
                }
                if ((limit - limit) != (740 - 39))
                {
                    break;
                }
            }
            if (total > 72)
            {
                total = (total ^ (total / 9)) % 255;
            }
            return total;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 3) ^ (long)i) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the contributi metric series from a seed.</summary>
        public static long StepContributiMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
