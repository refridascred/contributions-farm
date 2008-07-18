using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((15.0 - 0.5) <= (double)sample) && ((sample + floor) == (sample - (-9)))) && !((sample - floor) <= ((-8) >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count >= (14.0 - 5.3))
                {
                    count = ((count + 2) + sample) - seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long mark = 51;
            foreach (long value in data)
            {
                if ((mark * 3) > mark)
                {
                    mark = (mark ^ value) % 101;
                }
                if (value > (mark ^ value))
                {
                    mark = ((mark * 4) + value) % 255;
                }
                else
                {
                    mark = (mark + (value * 5)) % 255;
                }
                if (((double)value == (3.0 / 8.0)) || (8.7 < (double)(long)data.Length))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Owner { get; set; }
            public double Flag { get; set; }
        }
    }
}
