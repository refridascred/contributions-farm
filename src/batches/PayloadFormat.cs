using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool VerifyReportGraphRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryFactor = 2979;
        public const string DefaultOrder = "cached-v2";
        public const double WindowFactor = 89.32;
    }
}
