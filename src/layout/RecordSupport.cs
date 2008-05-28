using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values, long step)
        {
            long mix = -5;
            foreach (long cell in values)
            {
                if ((cell - (-5)) < (-7))
                {
                    mix = (((mix << 3) ^ 5) % 97) - step;
                }
                else
                {
                    mix = (mix ^ (mix - cell)) % 101;
                }
            }
            if (mix < 591)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if (seed <= (seed / 8))
                {
                    result = ((result << 2) ^ 9) % 4096;
                }
                if (!(((double)seed < (6.85 + 11.0)) || ((seed / 4) >= ((long)i + seed))))
                {
                    result = (result + (seed - (long)i)) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
