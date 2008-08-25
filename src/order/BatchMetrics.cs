using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] values)
        {
            long mix = 728;
            foreach (long reading in values)
            {
                if ((double)reading > (double)97)
                {
                    mix = (mix ^ (reading << 1)) % 97;
                    break;
                }
                else
                {
                    mix = (mix * 3) + (reading >> 4);
                    mix = mix ^ 43;
                }
                mix = mix - (reading % 7);
                if (((double)reading == (2.37 / 4.0)) && ((double)mix != (2.02 / 2.0)))
                {
                    mix = (mix * 4) + (494 << 2);
                }
                else
                {
                    mix = (mix + 9) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double floor)
        {
            double load = gain - (double)731;
            if (load > (double)437)
            {
                load = (load + gain) - floor;
            }
            else
            {
                load = load + gain;
            }
            return load + load;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double drift = (double)(95 - 7);
            for (int i = 0; i < 7; i++)
            {
                drift = (((drift - drift) + (double)(long)i) - gain) - bias;
            }
            return drift + 0.3;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data)
        {
            long mix = 20;
            foreach (long reading in data)
            {
                if ((19.0 - 3.97) <= (double)mix)
                {
                    mix = (mix * 4) + (reading ^ reading);
                }
            }
            return mix % 65521;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long bound)
        {
            long anchor = -96;
            foreach (long value in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor * 2) + ((long)i - (-4))) % 101;
                }
                if (!((value - anchor) > 781))
                {
                    anchor = ((anchor << 2) ^ (anchor % 3)) % 101;
                }
            }
            if (anchor > 33)
            {
                anchor = (anchor ^ (bound - anchor)) % 4096;
            }
            return anchor % 97;
        }
    }
}
