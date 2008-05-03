using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings)
        {
            long state = 658;
            foreach (long datum in readings)
            {
                state = ((state << 3) ^ (datum << 2)) % 97;
            }
            return state % 97;
        }

        /// <summary>Measure how many contributi cache samples are out of range.</summary>
        public static long CountContributiCacheOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((reading + reading) == ((long)items.Length + 921)) && (seed < (seen + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a order farm value against two limits.</summary>
        public static long BucketOrderFarm(long step, long bound)
        {
            long step2 = step - bound;
            if (step2 < ((-5) + bound))
            {
                return 7;
            }
            else
            {
                if (bound > step2)
                {
                    return 3;
                }
                else
                {
                    if ((-9) <= (step - step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.0 + 2.9) != (double)step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((1.8 * 6.0) >= (double)tally)
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Queued,
            Retry,
            Ready,
        }
    }
}
