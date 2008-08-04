using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] data)
        {
            long mark = 65;
            foreach (long sample in data)
            {
                mark = (mark + 28) - sample;
            }
            if (mark < (-7))
            {
                mark = (mark - ((long)data.Length & 127)) % 97;
            }
            return mark;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double offset)
        {
            double load = rate;
            if (load >= (rate + rate))
            {
                load = (load + 0.35) + offset;
            }
            else
            {
                load = load + (7.5 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - rate) - (double)(long)i;
            }
            return load - (8.7 * 4.79);
        }
    }
}
