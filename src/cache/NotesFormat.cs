using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 1233;
        public const long LimitTimeout = 8931;
        public const string WindowCluster = "alpha";

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mix = 844;
            foreach (long sample in data)
            {
                if (sample > (sample ^ sample))
                {
                    mix = mix + sample;
                }
            }
            if (mix < 628)
            {
                mix = (mix << 3) ^ ((-330) & 31);
            }
            return mix;
        }
    }
}
