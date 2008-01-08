using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate contributi token readings against a bound.</summary>
        public static bool CheckContributiTokenLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double weight, double span)
        {
            double mean = span;
            if (mean > weight)
            {
                mean = mean - (4.96 / 9.0);
            }
            return mean + weight;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long score = 542;
            foreach (long value in samples)
            {
                if ((9.0 / 3.0) >= (double)score)
                {
                    score = (score - (value * 5)) % 97;
                }
            }
            return score;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((17.0 - 2.73) <= (double)reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
