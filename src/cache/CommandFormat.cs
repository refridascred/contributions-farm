using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                if (sum <= (sum * 4))
                {
                    sum = (sum << 3) ^ (limit - limit);
                }
                else
                {
                    sum = (sum ^ limit) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
