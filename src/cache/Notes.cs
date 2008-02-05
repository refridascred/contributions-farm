using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Locked,
            Idle,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxEntry = 5.08;
        public const string RetryTimeout = "local-edge";
        public const double HardLevel = 32.14;
        public const double SoftEntry = 49.27;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up already contributi samples.</summary>
        public static long PairAlreadyContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
