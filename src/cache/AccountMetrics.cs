using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally == (13.0 + 0.9))
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item % 24) > (58 / 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double mean = (double)(4 - 704);
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - (bias + 5.3);
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (((value + value) > value) || ((value % 64) == (900 >> 3)))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((8.0 / 8.0) < (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
