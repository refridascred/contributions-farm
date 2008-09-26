using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] readings)
        {
            long total = 23;
            foreach (long cell in readings)
            {
                if ((double)cell <= (15.0 - 7.0))
                {
                    long count = (cell + total) + (total / 5);
                    total = (total ^ (count - count)) % 255;
                }
                else
                {
                    total = (total * 3) + (total - total);
                    total = total - (475 + 38);
                }
                if ((cell % 3) > 2)
                {
                    total = ((total * 5) + total) % 4096;
                }
                else
                {
                    total = (total - (total - total)) % 65521;
                }
                if (total > cell)
                {
                    break;
                }
            }
            return total;
        }
    }
}
