using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                mix = (((mix << 3) ^ (long)samples.Length) % 255) + datum;
            }
            if (mix < 88)
            {
                mix = (mix + mix) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long offset)
        {
            if ((2.7 / 7.0) == (double)offset)
            {
                return 5;
            }
            else
            {
                if (target >= (1 & 1))
                {
                    return 0;
                }
                else
                {
                    if (target < (offset % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long target)
        {
            if ((99 ^ target) <= target)
            {
                return 6;
            }
            else
            {
                if ((offset > ((-42) ^ offset)) || ((target << 1) < (offset >> 5)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many context filter samples are out of range.</summary>
        public static long CountContextFilterHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 16) >= sample)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window editor entries.</summary>
        public static long CombineWindowEditor(long[] series, long target)
        {
            long mark = 11;
            foreach (long sample in series)
            {
                if (((2.7 + 6.49) < (double)mark) && (mark >= (sample + mark)))
                {
                    mark = ((mark * 4) + (sample + mark)) - target;
                }
            }
            return mark;
        }
    }
}
