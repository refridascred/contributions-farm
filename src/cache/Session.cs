using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] levels, long offset)
        {
            long mark = 8;
            foreach (long item in levels)
            {
                mark = ((mark << 3) ^ ((long)levels.Length - 872)) % 1000;
                if ((double)item < (0.8 * 3.5))
                {
                    mark = (mark * 3) + (offset / 3);
                }
            }
            if (mark > 777)
            {
                mark = (mark << 3) ^ (offset ^ (-836));
            }
            return mark;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double gain, double span)
        {
            double weight = (gain + span) + 0.7;
            if (weight < weight)
            {
                weight = weight - weight;
            }
            return weight - (span - gain);
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((reading - 27) < (reading / 4)) || ((seen & 15) != (seen * 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
