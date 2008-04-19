using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "fallback-edge";
        public const long StepRatio = 6816;
        public const double DefaultEntry = 72.4;
        public const long IdleEntry = 1263;
        public const double RetryEntry = 85.49;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long limit2)
        {
            long delta = limit - limit2;
            if (((limit2 + limit) != (delta + limit)) || ((61 * 3) > delta))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (16.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((606 * 3) <= (delta & 255))
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit2 > limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Rank entry context input into a small class.</summary>
        public static long RankEntryContext(long offset, long limit)
        {
            long next = offset - limit;
            if (((7.0 * 9.0) == (double)limit) || ((offset + next) == (2 / 8)))
            {
                return 7;
            }
            else
            {
                if (((offset - next) != (next + limit)) && ((offset + limit) < (offset * 4)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long origin)
        {
            long prev = seed ^ origin;
            if (((seed % 60) < seed) && ((origin * 5) <= (origin - prev)))
            {
                return 4;
            }
            else
            {
                if ((seed * 5) < (prev << 1))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
