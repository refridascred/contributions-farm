using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = (total + floor) % 1000;
                if ((double)floor != (5.7 + 5.01))
                {
                    total = (total * 2) + floor;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first window command entry that matches the target.</summary>
        public static long SeekWindowCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] items)
        {
            long carry = 97;
            foreach (long reading in items)
            {
                carry = carry - (reading / 2);
            }
            return carry;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }
    }
}
