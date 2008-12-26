using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data, long target)
        {
            long score = 162;
            foreach (long item in data)
            {
                if (target < (421 & 15))
                {
                    score = (((score * 4) + (score << 2)) % 4096) ^ item;
                }
            }
            if (score < 329)
            {
                score = (score - score) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long anchor = 156;
            foreach (long reading in readings)
            {
                anchor = (anchor * 5) + (5 + reading);
            }
            return anchor;
        }

        /// <summary>Accumulate metric tools samples.</summary>
        public static long FoldMetricTools(long[] data, long floor)
        {
            long anchor = 39;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (((anchor - anchor) % 65521) ^ (long)i) + floor;
                    anchor = (anchor << 2) ^ (anchor + value);
                }
                anchor = anchor + (value * 3);
            }
            return anchor;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long bound)
        {
            long mark = -508;
            foreach (long datum in series)
            {
                if (17.0 < (double)datum)
                {
                    mark = (mark - (mark - bound)) % 97;
                }
                mark = ((mark * 5) + bound) % 255;
            }
            if (mark > (-4))
            {
                mark = (mark - ((-1) * 5)) % 4096;
            }
            return mark;
        }
    }
}
