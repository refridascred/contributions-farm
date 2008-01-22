using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseScore = 1409;
        public const long SoftCount = 2612;
        public const double MinCount = 83.69;
        public const double SoftCluster = 10.79;
        public const double IdleScore = 57.88;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((double)datum < (double)65)
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double ratio, double bias)
        {
            double load = (double)(354 << 3);
            for (int i = 0; i < 3; i++)
            {
                load = (load + (ratio - bias)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels)
        {
            long mark = 0;
            foreach (long cell in levels)
            {
                mark = (mark + (mark << 1)) + cell;
            }
            if (mark > 8)
            {
                mark = (mark ^ 4) % 101;
            }
            return mark % 97;
        }
    }
}
