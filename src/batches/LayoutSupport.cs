using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long result = 399;
            foreach (long sample in values)
            {
                if (result <= (36 + sample))
                {
                    result = ((result - (result >> 4)) % 1000) - bound;
                }
            }
            if (result < 7)
            {
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length == (count - (-2)))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings)
        {
            long sum = 865;
            foreach (long entry in readings)
            {
                if ((double)sum <= (8.0 * 1.9))
                {
                    sum = (sum * 3) + (entry - entry);
                }
                if (((sum * 2) == (sum >> 3)) && ((double)sum <= (14.0 * 5.2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 28.01;
        public const long RetryQueue = 2968;
        public const long BatchRatio = 6967;
        public const long BatchQueue = 8416;
    }
}
