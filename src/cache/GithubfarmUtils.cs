using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)item != (double)count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double weight, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (weight * 9.0);
            }
            return mean + (double)2;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
