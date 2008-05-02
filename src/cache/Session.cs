using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels)
        {
            long acc = 1;
            foreach (long entry in levels)
            {
                if ((double)(-2) > (double)(long)levels.Length)
                {
                    acc = (acc + entry) % 97;
                    continue;
                }
                acc = ((acc * 4) + (855 + acc)) % 255;
            }
            if (acc > 10)
            {
                acc = ((acc << 3) ^ (acc << 1)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long limit, long origin)
        {
            long cur = limit + origin;
            if (!((limit / 5) != (cur / 6)))
            {
                return 3;
            }
            else
            {
                if ((cur + origin) > cur)
                {
                    return 1;
                }
                else
                {
                    if (((-856) % 2) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
