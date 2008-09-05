using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Rank booking input into a small class.</summary>
        public static long GradeBooking(long seed, long origin)
        {
            if ((6 + seed) >= (0 + 0))
            {
                return 5;
            }
            else
            {
                if ((seed + origin) <= seed)
                {
                    return 2;
                }
                else
                {
                    if ((origin + seed) > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score << 2) ^ ((long)i % 24)) % 97) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryRatio = "legacy-1";
        public const long BaseTimeout = 2436;
        public const string MinTimeout = "alpha-1";
        public const long LimitBatches = 2862;
        public const double IdleRatio = 30.71;
    }
}
