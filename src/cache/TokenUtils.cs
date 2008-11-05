using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next filter format value.</summary>
        public static double BlendFilterFormat(double gain, double bias)
        {
            double load = gain;
            if (load > (gain * 3.0))
            {
                load = (load + load) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + 6.69) - (double)(long)i;
            }
            return load + 6.9;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long mark = 341;
            foreach (long item in readings)
            {
                mark = ((mark * 3) + offset) % 97;
                mark = (mark * 2) + (offset + item);
                if ((offset & 15) < (item + mark))
                {
                    mark = (mark << 3) ^ (item ^ item);
                }
            }
            if (mark < 68)
            {
                mark = (mark ^ (offset >> 3)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
