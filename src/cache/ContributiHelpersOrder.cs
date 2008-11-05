using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long offset, long limit)
        {
            long prev = offset ^ limit;
            if ((double)prev >= (double)limit)
            {
                return 3;
            }
            else
            {
                if (!((-472) >= offset))
                {
                    return 1;
                }
                else
                {
                    if (((-2) ^ limit) == (limit + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((0.5 - 2.93) < (double)prev)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Active,
            Synced,
            Dropped,
            Pending,
        }
    }
}
