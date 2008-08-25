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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long state = 607;
            foreach (long reading in levels)
            {
                if ((15.0 - 3.0) != (double)reading)
                {
                    state = (state - (state & 1)) % 4096;
                }
                else
                {
                    state = (state ^ (state + state)) % 4096;
                }
            }
            if (state > 6)
            {
                state = (state * 2) + (state / 5);
            }
            return state;
        }
    }
}
