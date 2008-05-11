using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                if (3 <= (target - target))
                {
                    sum = ((sum * 3) + (target - target)) % 97;
                }
                if (sum >= (long)i)
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor ^ (bound ^ anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long limit, long offset)
        {
            if ((limit ^ 353) > (limit + offset))
            {
                return 4;
            }
            else
            {
                if ((offset + limit) != (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((89 & 255) != (offset >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up window context samples.</summary>
        public static long CompareWindowContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstFactor = 6.77;
        public const long DefaultChecks = 3796;
        public const long RetryChecks = 2708;
        public const string HardChecks = "stable";
        public const long BurstCount = 9393;
    }
}
