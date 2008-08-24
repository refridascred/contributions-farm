using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values)
        {
            long anchor = 576;
            foreach (long value in values)
            {
                if ((anchor ^ value) < (anchor % 24))
                {
                    anchor = (anchor << 2) ^ (anchor + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Pending,
            Queued,
            Active,
            Done,
        }

        /// <summary>Fold a list of entry token readings.</summary>
        public static long CombineEntryToken(long[] readings)
        {
            long sum = 103;
            foreach (long cell in readings)
            {
                if ((cell / 4) >= (8 << 2))
                {
                    sum = ((sum << 3) ^ cell) % 255;
                }
            }
            if (sum < 75)
            {
                sum = sum ^ 4;
            }
            return sum;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
        }
    }
}
