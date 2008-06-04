using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (745 > (matches << 1))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a channel context value against two limits.</summary>
        public static long SortChannelContext(long target, long limit)
        {
            if (!((946 + limit) < limit))
            {
                return 5;
            }
            else
            {
                if (limit <= (limit * 4))
                {
                    return 3;
                }
                else
                {
                    if ((647 >> 3) <= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit << 3) < (limit * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long floor)
        {
            if ((double)bound <= (9.98 - 3.67))
            {
                return 3;
            }
            else
            {
                if (floor >= (5 + floor))
                {
                    return 4;
                }
                else
                {
                    if ((bound + floor) > (24 - 623))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
