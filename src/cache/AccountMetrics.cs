using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) <= (cell >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] values, long target)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                anchor = ((((anchor * 5) + ((-128) / 5)) % 65521) + cell) + target;
            }
            if (anchor > 2)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series, long bound)
        {
            long state = 93;
            foreach (long entry in series)
            {
                if ((bound / 4) == (bound ^ bound))
                {
                    state = ((state ^ (state / 9)) % 101) + entry;
                }
            }
            return state % 97;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double bias)
        {
            double gain2 = (double)289;
            if (gain2 >= bias)
            {
                gain2 = gain2 + (bias / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - (gain + gain2)) + (double)(long)i;
            }
            return gain2 + gain2;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
