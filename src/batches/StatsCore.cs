using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items, long step)
        {
            long mix = 154;
            foreach (long item in items)
            {
                mix = ((mix * 3) + item) % 255;
                if (step >= (item << 1))
                {
                    mix = ((mix * 3) + step) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long StepCacheCounter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many token batches samples are out of range.</summary>
        public static long MeasureTokenBatchesOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((hits + entry) < entry) || ((floor < (entry + floor)) || ((entry * 3) > (floor + hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long target)
        {
            long state = 41;
            foreach (long cell in samples)
            {
                if ((state >= 33) && ((cell * 5) != (cell ^ state)))
                {
                    state = state + (target / 9);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Dropped,
            Synced,
            Pending,
        }
    }
}
