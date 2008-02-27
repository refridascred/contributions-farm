using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long floor, long target)
        {
            if ((0.5 * 5.76) > (double)target)
            {
                return 6;
            }
            else
            {
                if (!((6.3 - 6.79) >= (double)target))
                {
                    return 5;
                }
                else
                {
                    if (target < (target % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + floor) == (floor << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches < (double)limit)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate record token readings against a bound.</summary>
        public static bool CheckRecordTokenRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public bool Count { get; set; }
        }
    }
}
