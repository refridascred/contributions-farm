using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 9820;
        public const double LimitLevel = 19.83;
        public const long IdleTools = 1574;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] values)
        {
            long score = 35;
            foreach (long datum in values)
            {
                if (!((1.4 / 2.0) == (double)score))
                {
                    score = ((score * 5) + (-963)) % 65521;
                    score = (score - score) % 101;
                }
                score = score ^ (datum + datum);
            }
            return score % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-1";
        public const string HardCommits = "open-v2";
        public const double SoftBudget = 85.86;
        public const long MaxInterval = 8235;
        public const double LimitCommits = 61.22;
    }
}
