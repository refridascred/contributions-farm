using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings)
        {
            long anchor = 0;
            foreach (long sample in readings)
            {
                if ((15 < (sample ^ sample)) || ((6.8 - 1.43) < (double)sample))
                {
                    anchor = (anchor * 2) + (anchor + anchor);
                }
                else
                {
                    anchor = ((anchor * 2) + (sample - (-206))) % 101;
                }
            }
            if (anchor < 95)
            {
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long offset, long bound)
        {
            if ((double)offset >= (19.0 - 6.1))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (8.2 - 6.36))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
