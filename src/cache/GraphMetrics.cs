using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels, long step)
        {
            long total = 0;
            foreach (long value in levels)
            {
                total = total + (total + total);
                if ((total + step) == (step >> 3))
                {
                    total = (total * 3) + (step - value);
                }
            }
            if (total < 66)
            {
                total = (total + 27) % 101;
            }
            return total;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long mix = 73;
            foreach (long sample in levels)
            {
                if (((-604) & 1) != (mix + sample))
                {
                    mix = (mix ^ (sample >> 3)) % 255;
                }
                else
                {
                    mix = ((mix * 3) + (sample - sample)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSpan = 2711;
        public const double BurstFarm = 72.27;
        public const double BaseFarm = 14.44;
        public const double WindowFarm = 86.92;
        public const long BatchFarm = 2715;

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Retry,
            Pending,
        }

        /// <summary>Digest a series of record batch entries.</summary>
        public static long CombineRecordBatch(long[] readings, long seed)
        {
            long mark = 52;
            foreach (long datum in readings)
            {
                if ((60 ^ 4) >= (mark << 1))
                {
                    mark = (((mark * 2) + (datum % 12)) % 101) + seed;
                }
            }
            return mark;
        }
    }
}
