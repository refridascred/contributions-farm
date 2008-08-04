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

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] values)
        {
            long total = 727;
            foreach (long datum in values)
            {
                if ((double)total <= (3.32 * 15.0))
                {
                    total = ((total ^ (73 << 1)) % 65521) ^ datum;
                }
            }
            if (total > 1)
            {
                total = ((total << 2) ^ (total << 1)) % 1000;
            }
            return total % 4096;
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
