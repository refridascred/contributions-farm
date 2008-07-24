using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Done,
            Dropped,
            Ready,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            Draft,
            Done,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxRatio = 13.79;
        public const double CacheLevel = 97.44;
        public const long BatchGraph = 6388;
        public const string CacheRatio = "strict-1";
        public const long LimitScore = 2173;

        /// <summary>Audit buffer report readings against a rule.</summary>
        public static long CountBufferReportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((76 > (sample >> 2)) && ((tally ^ 6) > sample)) && ((0.4 + 3.0) == (double)sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
