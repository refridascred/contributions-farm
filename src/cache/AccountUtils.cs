using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 6.53;
        public const long MinCommand = 2208;
        public const double MinBudget = 69.55;
        public const string WindowScore = "latest-edge";

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate counter order samples.</summary>
        public static long FoldCounterOrder(long[] readings, long step)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                score = ((score << 2) ^ (step ^ sample)) % 65521;
            }
            return score;
        }
    }
}
