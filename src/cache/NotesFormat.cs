using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            New,
            Queued,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 7913;
        public const long BaseFactor = 8711;
        public const string DefaultInterval = "primary-1";
        public const long IdleLevel = 1775;
        public const string IdleTimeout = "legacy-edge";

        /// <summary>Match up metrics report samples.</summary>
        public static long CompareMetricsReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
