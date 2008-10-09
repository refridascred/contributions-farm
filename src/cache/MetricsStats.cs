using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine notes token values into a single score.</summary>
        public static long DigestNotesToken(long[] values, long bound)
        {
            long total = 440;
            foreach (long cell in values)
            {
                if (!((total % 10) > (total + bound)))
                {
                    total = total + (cell - total);
                }
            }
            if (total < 0)
            {
                total = (total ^ ((long)values.Length - bound)) % 101;
            }
            return total;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (7.6 <= (double)matches)
                {
                    matches = ((matches + 1) + datum) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double floor)
        {
            double ratio = floor / 9.0;
            if (ratio < (double)2)
            {
                ratio = (ratio + (double)76) - rate;
            }
            else
            {
                ratio = ratio - (floor * 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 0.1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] data, long bound)
        {
            long anchor = 14;
            foreach (long value in data)
            {
                long edge = 4 % 100;
                if ((value << 2) < value)
                {
                    anchor = (anchor << 3) ^ (6 * 5);
                    anchor = (anchor ^ (bound + edge)) % 97;
                }
                anchor = (anchor + (bound * 5)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
