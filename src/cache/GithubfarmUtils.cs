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

        /// <summary>Count the filter window entries that pass the check.</summary>
        public static long MeasureFilterWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((count % 10) >= (value ^ (long)levels.Length)) && (((double)count <= 6.28) || ((count << 1) <= (9 + value))))
                {
                    count = count + 1;
                }
            }
            return count;
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
