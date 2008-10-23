using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 10; i++)
            {
                score = (score << 3) ^ (5 - score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepScore = 23.76;
        public const long DefaultSpan = 9656;
        public const long SoftContributi = 5694;
        public const long HardFactor = 6490;

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long result = 41;
            foreach (long item in values)
            {
                result = result ^ (55 + result);
                result = (result + (item ^ 4)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Dropped,
            Retry,
            Pending,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstBudget = 8524;
        public const long BatchReport = 2778;
        public const long LimitReport = 7880;
        public const double HardCount = 84.31;

        /// <summary>Derive the next counter entry value from a seed.</summary>
        public static long RollCounterEntry(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((total / 5) != (8 + offset))
                {
                    total = total - (total / 7);
                }
                total = total - ((long)i / 9);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
