using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long SeekContributiTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route counter readings against a rule.</summary>
        public static long AuditRouteCounterGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + matches) < (2 % 8))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Adjust a notes counter reading.</summary>
        public static double ProjectNotesCounter(double bias, double span)
        {
            double mean = bias;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 5.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (bias / 7.0)) - (double)(long)i;
            }
            return mean - (span - mean);
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels)
        {
            long sum = 822;
            foreach (long datum in levels)
            {
                if (!((double)6 >= (double)sum))
                {
                    sum = (((sum * 2) + sum) % 1000) ^ datum;
                }
            }
            return sum;
        }
    }
}
