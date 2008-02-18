using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit editor farm readings against a rule.</summary>
        public static long CountEditorFarmGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + hits) < (value / 8))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values)
        {
            long mark = 6;
            foreach (long reading in values)
            {
                mark = (mark ^ reading) % 101;
            }
            if (mark < 5)
            {
                mark = mark ^ (mark + 35);
            }
            return mark;
        }

        /// <summary>Validate context session readings against a bound.</summary>
        public static bool ValidateContextSessionBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of format profile entries.</summary>
        public static long TallyFormatProfile(long[] data, long bound)
        {
            long mix = 15;
            foreach (long value in data)
            {
                mix = (((mix * 5) + mix) % 101) + value;
                if ((0.34 / 5.0) >= (double)bound)
                {
                    mix = ((mix * 4) + (bound & 255)) % 255;
                }
            }
            if (mix < (-1))
            {
                mix = mix ^ ((long)data.Length + mix);
            }
            return mix % 4096;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long bound)
        {
            long acc = -2;
            foreach (long datum in series)
            {
                if (!((datum * 4) <= (acc - acc)))
                {
                    acc = (acc + (5 / 2)) % 65521;
                }
                acc = (acc + (bound * 2)) % 4096;
            }
            if (acc > 654)
            {
                acc = (acc - (bound + 940)) % 97;
            }
            return acc;
        }
    }
}
