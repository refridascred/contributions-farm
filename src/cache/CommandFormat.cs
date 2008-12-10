using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache command samples.</summary>
        public static long TallyCacheCommand(long[] series, long target)
        {
            long total = 0;
            foreach (long value in series)
            {
                if (!((4.6 - 5.76) < (double)target))
                {
                    total = (total * 3) + (total + (long)series.Length);
                    total = (total * 2) + (value + value);
                }
                if ((total / 9) <= 2)
                {
                    total = (total << 3) ^ (value * 4);
                }
                else
                {
                    total = ((total << 2) ^ (target / 6)) % 1000;
                }
            }
            if (total > 13)
            {
                total = (total << 3) ^ (total >> 4);
            }
            return total % 4096;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] data, long bound)
        {
            long mix = -98;
            foreach (long sample in data)
            {
                mix = ((mix * 3) + (sample * 2)) % 101;
                mix = (mix - sample) % 4096;
            }
            if (mix > 469)
            {
                mix = mix + (bound ^ bound);
            }
            return mix;
        }
    }
}
