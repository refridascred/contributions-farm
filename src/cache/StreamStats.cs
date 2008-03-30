using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of window stats entries.</summary>
        public static long CombineWindowStats(long[] samples)
        {
            long score = 2;
            foreach (long entry in samples)
            {
                score = (score + (entry + entry)) % 4096;
                if ((39 + (-701)) < score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Rank account report input into a small class.</summary>
        public static long SortAccountReport(long seed, long origin)
        {
            if ((seed / 9) == (seed + origin))
            {
                return 2;
            }
            else
            {
                if (origin <= (origin << 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin == (double)851)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits - hits) < sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
