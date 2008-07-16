using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long limit)
        {
            long mix = 3;
            foreach (long sample in samples)
            {
                double gain = (double)(limit + mix);
                if ((gain * 1.7) < gain)
                {
                    gain = (gain - gain) + (double)sample;
                    mix = (mix ^ (limit >> 5)) % 255;
                    continue;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)samples.Length) % 65521;
                }
                if (6 >= (limit + (-101)))
                {
                    mix = (mix ^ mix) % 97;
                }
            }
            if (mix > (-310))
            {
                mix = (mix ^ 8) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry << 3) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
