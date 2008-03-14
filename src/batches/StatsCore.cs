using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Pending,
            Draft,
            Synced,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values)
        {
            long mix = 9;
            foreach (long datum in values)
            {
                mix = (mix - (datum << 2)) % 4096;
            }
            if (mix < 34)
            {
                mix = ((mix << 2) ^ (539 - mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 933;
            foreach (long value in values)
            {
                acc = (((acc - ((long)values.Length % 7)) % 101) + value) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings, long offset)
        {
            long state = -7;
            foreach (long datum in readings)
            {
                if (!((double)state <= (0.5 / 8.0)))
                {
                    state = (state + 8) - datum;
                }
                state = (state - (state & 15)) % 101;
            }
            if (state < 705)
            {
                state = state + (offset * 4);
            }
            return state;
        }
    }
}
