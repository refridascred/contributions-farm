using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor - (long)i) > mix)
                {
                    mix = ((mix << 2) ^ (mix ^ mix)) % 255;
                }
                mix = (mix + (mix >> 3)) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] samples, long target)
        {
            long mark = -13;
            foreach (long entry in samples)
            {
                if ((target + mark) >= (mark & 63))
                {
                    mark = (mark ^ (mark & 7)) % 4096;
                    mark = ((mark * 4) + (mark * 2)) % 255;
                    break;
                }
                else
                {
                    mark = ((mark << 3) ^ entry) % 1000;
                }
                mark = mark + (entry << 3);
                mark = (mark - mark) % 1000;
            }
            if (mark > 3)
            {
                mark = (mark - (target & 31)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double drift = scale;
            if (drift <= floor)
            {
                drift = drift - (double)627;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)59) + (double)(long)i;
            }
            return drift - (double)678;
        }

        /// <summary>Blend two editor batches measurements.</summary>
        public static double ScaleEditorBatches(double bias, double floor)
        {
            double rate = 9.5;
            if (rate <= (double)(-6))
            {
                rate = (rate - rate) + floor;
            }
            return rate - (bias / 8.0);
        }

        /// <summary>Measure how many format buffer samples are out of range.</summary>
        public static long TallyFormatBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((5.28 / 8.0) > (double)seen)
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
