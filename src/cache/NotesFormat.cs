using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - sum) % 101;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleWidth = 51.05;
        public const string BurstCommits = "latest";
        public const long IdleCommits = 3985;
        public const long HardCommits = 8828;
        public const long DefaultCommits = 4848;
    }
}
