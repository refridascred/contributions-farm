using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if (floor <= 916)
            {
                return 8;
            }
            else
            {
                if ((11 - slot) < (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if (slot > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor2 % 97) != (60 + slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state << 3) ^ (long)i) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            long bound = step - origin;
            if (((bound + 588) >= (step % 100)) || ((bound / 2) > 957))
            {
                return 2;
            }
            else
            {
                if (!((double)origin != (12.0 - 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound < 1.4)
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (origin >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits ^ (long)data.Length) >= target)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
