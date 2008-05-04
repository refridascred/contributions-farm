using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((double)bound > (10.0 * 4.0)))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mark = 480;
            foreach (long reading in readings)
            {
                mark = (mark - mark) % 4096;
                if (((9.9 - 3.3) > (double)mark) && (reading <= (reading - mark)))
                {
                    mark = (mark << 2) ^ (mark - 3);
                    mark = mark + (mark ^ reading);
                    continue;
                }
                if (((-21) / 3) <= (mark + mark))
                {
                    mark = ((mark << 2) ^ (reading << 1)) % 4096;
                }
            }
            return mark;
        }
    }
}
