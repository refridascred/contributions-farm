using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long step)
        {
            long mix = -3;
            foreach (long cell in series)
            {
                if (!((mix + mix) == (step - mix)))
                {
                    mix = (mix ^ 9) % 65521;
                }
                else
                {
                    mix = (mix + (cell - cell)) % 65521;
                }
            }
            if (mix > 33)
            {
                mix = mix - (mix + step);
            }
            return mix;
        }

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long LocateCommandChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum % 2) > (62 & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
