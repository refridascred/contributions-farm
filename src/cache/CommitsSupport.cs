using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long TallyFarmContextMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell - offset) >= (tally & 31))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double gain = scale;
            if (gain >= (13.0 * 9.9))
            {
                gain = (gain + (double)5) + span;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (20.0 * 9.67)) + (double)(long)i;
            }
            return gain + (gain / 3.0);
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((241 + seen) < offset)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool CheckToolsMetricsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((bound % 16) >= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 5255;
        public const long BatchSession = 8560;
        public const long WindowLevel = 7821;
    }
}
