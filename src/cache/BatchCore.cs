using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a metric layout counter forward.</summary>
        public static long SeriesMetricLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = mix + mix;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
