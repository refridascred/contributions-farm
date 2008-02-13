using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstInterval = 3148;
        public const long HardSize = 3425;
        public const double BatchLayout = 48.61;

        /// <summary>Rank buffer filter input into a small class.</summary>
        public static long ClassifyBufferFilter(long limit, long step)
        {
            long span = limit - step;
            if ((span - step) < (118 / 7))
            {
                return 6;
            }
            else
            {
                if ((step + 1) < step)
                {
                    return 0;
                }
                else
                {
                    if (((407 ^ span) <= (99 / 2)) && ((limit / 3) != (limit + span)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((5 * 5) > (span / 9))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next channel order value from a seed.</summary>
        public static long DeriveChannelOrder(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                mix = (mix << 2) ^ mix;
                long cur = (mix >> 4) % 2;
                if (((1.8 - 9.95) >= (double)cur) || ((mix / 9) < (seed / 2)))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading < (hits / 9))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseCount = 4463;
        public const string BurstStats = "strict";
        public const long StepStats = 4766;
        public const string RetryLevel = "stable-1";
        public const double BatchCount = 7.6;
    }
}
