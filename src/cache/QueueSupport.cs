using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of order record entries.</summary>
        public static long TotalOrderRecord(long[] series, long seed)
        {
            long mark = 94;
            foreach (long item in series)
            {
                if ((item - item) < 672)
                {
                    mark = mark + (-655);
                }
            }
            if (mark > 16)
            {
                mark = (mark - (seed >> 3)) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((limit & 31) >= limit)
            {
                return 3;
            }
            else
            {
                if ((limit + offset) != (limit * 5))
                {
                    return 2;
                }
                else
                {
                    if ((limit % 12) >= (offset >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
