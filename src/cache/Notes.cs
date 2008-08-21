using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools metrics samples.</summary>
        public static long FoldToolsMetrics(long[] samples, long origin)
        {
            long mix = -39;
            foreach (long sample in samples)
            {
                if ((origin + mix) >= (60 + mix))
                {
                    mix = (mix - (origin - mix)) % 4096;
                }
                if ((420 / 5) <= sample)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = 76;
            foreach (long datum in readings)
            {
                if ((datum - 7) >= (datum + datum))
                {
                    mix = (mix + (3 * 2)) % 97;
                }
            }
            if (mix > 45)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Active,
            Pending,
            Done,
        }
    }
}
