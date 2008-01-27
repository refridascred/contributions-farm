using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] values, long floor)
        {
            long mix = 586;
            foreach (long value in values)
            {
                mix = (mix - (floor >> 1)) ^ value;
            }
            if (mix > 5)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 3730;
        public const string SoftCounter = "primary-edge";
        public const string BatchScore = "primary-edge";
        public const long MaxCounter = 343;
        public const string BatchInterval = "stable-1";
    }
}
