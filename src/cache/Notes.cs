using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long TallySessionCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double scale = (double)(93 / 8);
            if (scale <= (scale / 5.0))
            {
                scale = ((scale - (double)7) + bias) - bias2;
            }
            return scale + scale;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Stale,
            Done,
        }
    }
}
