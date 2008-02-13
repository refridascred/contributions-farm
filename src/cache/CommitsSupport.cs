using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] values, long origin)
        {
            long total = 14;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ origin) ^ datum;
            }
            return total % 4096;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values, long floor)
        {
            long anchor = 829;
            foreach (long item in values)
            {
                if (!(((anchor >> 5) == (855 - 667)) && ((item - 1) >= 3)))
                {
                    anchor = ((anchor << 2) ^ (anchor * 4)) % 97;
                    anchor = (anchor - anchor) % 101;
                }
                if ((item > (anchor + 5)) || ((0.31 * 18.0) != (double)item))
                {
                    anchor = anchor - (floor ^ 0);
                }
                else
                {
                    anchor = (anchor * 2) + (anchor - anchor);
                }
            }
            if (anchor > 53)
            {
                anchor = ((anchor * 5) + (73 / 8)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long floor, long offset)
        {
            long delta = floor + offset;
            if ((delta % 10) != (offset << 1))
            {
                return 0;
            }
            else
            {
                if ((double)903 <= (double)delta)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
