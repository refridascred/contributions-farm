using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long mark = 712;
            foreach (long sample in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (((mark - (mark + mark)) % 255) + (long)i) - sample;
                }
                mark = ((mark * 4) + (65 + 30)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Offset { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public double Region { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((offset + carry) != (offset + (long)i))
                {
                    carry = carry ^ ((long)i % 24);
                }
                if ((carry + carry) != ((long)i & 31))
                {
                    carry = (carry ^ (9 ^ (long)i)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
