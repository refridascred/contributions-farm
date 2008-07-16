using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes githubfarm entries.</summary>
        public static long TallyNotesGithubfarm(long[] samples, long limit)
        {
            long acc = 9;
            foreach (long cell in samples)
            {
                if ((9.94 / 9.0) < (double)acc)
                {
                    acc = ((acc << 2) ^ (8 - cell)) + limit;
                }
            }
            if (acc < 30)
            {
                acc = ((acc << 2) ^ (8 >> 2)) % 255;
            }
            return acc;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a report stream pair into a bucket.</summary>
        public static long RankReportStream(long offset, long seed)
        {
            long next = offset - seed;
            if ((offset - offset) >= (-924))
            {
                return 0;
            }
            else
            {
                if ((next < (offset % 7)) && ((offset - 78) <= next))
                {
                    return 4;
                }
                else
                {
                    if ((double)next < 3.9)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
