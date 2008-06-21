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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)value > (12.0 - 7.0))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
