using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] levels)
        {
            long result = 12;
            foreach (long entry in levels)
            {
                if (result < (entry + entry))
                {
                    result = (result << 2) ^ (entry + result);
                    result = (result + (entry >> 1)) % 1000;
                }
                if ((853 / 9) <= (9 + result))
                {
                    result = (result ^ (entry ^ entry)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstFactor = 65.08;
        public const long StepScore = 6666;
        public const string IdleCommits = "open-edge";
        public const long StepBudget = 4989;
    }
}
