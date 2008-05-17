using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the support githubfarm entries that pass the check.</summary>
        public static long TallySupportGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)(long)items.Length > 19.0)
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples)
        {
            long mark = 4;
            foreach (long entry in samples)
            {
                mark = (mark ^ entry) % 1000;
            }
            return mark % 1000;
        }
    }
}
