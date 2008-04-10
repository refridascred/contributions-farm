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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

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
