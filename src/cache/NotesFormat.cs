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

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (item + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-1";
        public const string HardCommits = "open-v2";
        public const double SoftBudget = 85.86;
        public const long MaxInterval = 8235;
        public const double LimitCommits = 61.22;
    }
}
