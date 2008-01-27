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

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 64;
            foreach (long datum in data)
            {
                if ((double)mix > (15.0 - 5.0))
                {
                    mix = mix ^ (5 + mix);
                }
                mix = (mix - (mix - mix)) % 97;
                if ((mix + datum) > datum)
                {
                    mix = (mix - (datum % 5)) % 101;
                }
            }
            if (mix < 48)
            {
                mix = ((mix * 2) + (mix >> 4)) % 97;
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
