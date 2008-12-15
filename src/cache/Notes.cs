using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Locked,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Combine channel buffer values into a single score.</summary>
        public static long CombineChannelBuffer(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                if (((4 >> 5) == (sample + state)) || ((double)state >= (double)695))
                {
                    state = state ^ (80 ^ sample);
                }
            }
            if (state > 7)
            {
                state = ((state << 3) ^ (state + state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Locate a githubfarm payload reading by value.</summary>
        public static long LookupGithubfarmPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
