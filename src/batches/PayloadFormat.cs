using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 45.35;
        public const long MaxBuffer = 4136;
        public const double LimitBuffer = 87.71;
        public const string LimitDepth = "standard-v2";

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
