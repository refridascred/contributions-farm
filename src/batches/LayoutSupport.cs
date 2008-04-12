using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (item < (144 + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            long step = offset - offset2;
            if (!(514 > step))
            {
                return 4;
            }
            else
            {
                if ((2.18 - 4.0) <= (double)offset2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long mix = 29;
            foreach (long sample in readings)
            {
                if (6 > (sample + sample))
                {
                    mix = mix - (sample ^ sample);
                }
            }
            return mix;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Synced,
            Pending,
            New,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
