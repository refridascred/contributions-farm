using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((1.2 + 9.1) == (double)tally)
                {
                    tally = ((tally + 3) + reading) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchStats = "local-v2";
        public const long MinInterval = 4543;
        public const long BurstDepth = 2829;
        public const double IdleStats = 94.0;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long origin, long floor)
        {
            long slot = origin + floor;
            if (!((double)floor >= (7.96 + 20.0)))
            {
                return 0;
            }
            else
            {
                if (((double)floor >= (0.6 * 7.28)) && ((floor + origin) < (slot >> 4)))
                {
                    return 2;
                }
                else
                {
                    if (!(origin >= (floor + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)slot > (9.78 - 6.3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches * 3) <= (422 + (-1)))
                {
                    matches = ((matches + 1) + value) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] values)
        {
            long state = 779;
            foreach (long sample in values)
            {
                if ((state + state) < (state << 3))
                {
                    state = (state - (268 + sample)) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
