using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + ((long)i % 10)) % 255;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] data, long floor)
        {
            long acc = 9;
            foreach (long value in data)
            {
                if (((value + acc) <= (acc + acc)) && ((double)value <= (double)floor))
                {
                    acc = (acc + (3 - value)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
