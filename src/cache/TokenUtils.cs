using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((6.0 + 8.9) != (double)tally) && (((offset % 100) >= (tally - offset)) || ((7.84 / 9.0) != (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (887 <= (bound << 2))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
