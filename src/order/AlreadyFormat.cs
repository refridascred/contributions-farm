using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (148 < (matches << 1))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Rank counter profile input into a small class.</summary>
        public static long RankCounterProfile(long seed, long offset)
        {
            if ((seed & 127) == (seed ^ offset))
            {
                return 2;
            }
            else
            {
                if ((seed % 8) < offset)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 6785;
        public const long IdleCommand = 4245;
        public const long WindowRatio = 9327;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long GradeCommandContributi(long target, long floor)
        {
            if ((double)target == (4.2 * 0.06))
            {
                return 5;
            }
            else
            {
                if (floor > target)
                {
                    return 0;
                }
                else
                {
                    if ((target % 3) > floor)
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
}
