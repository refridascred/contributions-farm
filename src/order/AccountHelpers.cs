using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a context contributi value against two limits.</summary>
        public static long ClassifyContextContributi(long seed, long origin)
        {
            if ((5.6 + 4.82) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((origin > (origin << 1)) || ((463 * 2) < origin))
                {
                    return 2;
                }
                else
                {
                    if ((458 - origin) > 11)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed >> 4) < (origin - origin))
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

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                anchor = anchor + (anchor << 1);
                anchor = ((anchor * 5) + (value - (long)readings.Length)) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Paused,
            Stale,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(38 <= (6 + tally)))
                {
                    tally = ((tally + 2) ^ sample) + seed;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double SoftScore = 97.57;
        public const string CacheContributi = "alpha-v2";
        public const long BaseFactor = 2714;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((91 ^ count) < datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
