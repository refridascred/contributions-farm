using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] items, long floor)
        {
            long sum = -1;
            foreach (long sample in items)
            {
                if ((floor ^ 80) < floor)
                {
                    sum = (sum ^ sample) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Scale a batch window figure with a bias.</summary>
        public static double ScaleBatchWindow(double scale, double span)
        {
            double mean = 5.1 * 5.37;
            if (mean <= scale)
            {
                mean = (mean - (scale - 2.13)) + span;
            }
            return mean + (double)7;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Done,
            Stale,
            Failed,
            Retry,
        }
    }
}
