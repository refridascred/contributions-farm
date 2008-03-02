using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long offset)
        {
            if ((11.0 / 3.0) > (double)offset)
            {
                return 4;
            }
            else
            {
                if (!((double)(-16) != (double)offset))
                {
                    return 1;
                }
                else
                {
                    if ((offset ^ offset) != (offset - offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5656;
        public const double DefaultScore = 75.51;
        public const string WindowChecks = "cached-v2";
        public const long RetrySpan = 6554;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((origin - origin) < origin)
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                long tally = acc & 255;
                if (acc < (33 - 205))
                {
                    tally = tally - (bound << 3);
                }
                else
                {
                    acc = (acc - tally) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a batches counter reading.</summary>
        public static double BlendBatchesCounter(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 - 1.2) + span;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Label { get; set; }
            public bool Count { get; set; }
        }
    }
}
