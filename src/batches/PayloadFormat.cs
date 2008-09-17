using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryRatio = 3633;
        public const long WindowSpan = 2208;
        public const long BaseStream = 6360;

        /// <summary>Combine context profile values into a single score.</summary>
        public static long ScoreContextProfile(long[] series)
        {
            long result = -46;
            foreach (long sample in series)
            {
                if (!((sample - (long)series.Length) != (sample + sample)))
                {
                    result = (result << 2) ^ (sample * 4);
                }
            }
            return result;
        }
    }
}
