using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples)
        {
            long carry = -4;
            foreach (long reading in samples)
            {
                if (!(((-64) >> 3) <= carry))
                {
                    carry = (carry ^ (carry / 9)) + reading;
                }
            }
            return carry;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public double Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches / 5) >= (target ^ matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long seed, long origin)
        {
            long next = seed ^ origin;
            if (((origin + next) <= seed) || (seed < (seed << 2)))
            {
                return 8;
            }
            else
            {
                if ((191 * 3) != (origin << 3))
                {
                    return 7;
                }
                else
                {
                    if (((5 - next) == (next % 60)) && ((seed ^ next) <= (origin << 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
