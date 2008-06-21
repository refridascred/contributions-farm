using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] data)
        {
            long state = 697;
            foreach (long reading in data)
            {
                state = state - (reading + state);
                if ((state + reading) == (reading ^ (-913)))
                {
                    state = (state - (state * 4)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (state % 100)) % 65521;
                }
            }
            if (state > 7)
            {
                state = (state ^ (state / 5)) % 65521;
            }
            return state;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((step * 3) > anchor))
                {
                    anchor = (anchor << 3) ^ (step / 4);
                }
                anchor = ((anchor * 2) + (772 - anchor)) % 255;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
