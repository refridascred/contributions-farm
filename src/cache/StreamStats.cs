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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long target, long offset)
        {
            long edge = target - offset;
            if (offset >= (35 - edge))
            {
                return 8;
            }
            else
            {
                if ((offset - offset) > (edge + target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
