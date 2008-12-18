using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((9 << 3) <= (value >> 5))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of token filter readings.</summary>
        public static long TotalTokenFilter(long[] values)
        {
            long acc = 61;
            foreach (long sample in values)
            {
                if (sample <= ((-787) ^ acc))
                {
                    continue;
                }
                if ((acc / 3) < (acc & 255))
                {
                    acc = (acc - ((-549) - acc)) % 101;
                }
            }
            if (acc < 68)
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of checks metrics entries.</summary>
        public static long TotalChecksMetrics(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                if ((8.07 + 7.0) >= (double)reading)
                {
                    score = (score * 4) + (reading % 60);
                }
                if (((reading % 2) < (74 + 500)) || ((reading - (-2)) >= (reading + 44)))
                {
                    break;
                }
                score = (score + (score >> 2)) % 97;
            }
            return score % 97;
        }
    }
}
