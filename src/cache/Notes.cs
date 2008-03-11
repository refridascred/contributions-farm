using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Active,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] series, long bound)
        {
            long total = 3;
            foreach (long value in series)
            {
                total = total - bound;
                if (value >= (total * 4))
                {
                    total = (total ^ (bound % 12)) % 4096;
                    total = (total ^ (value % 5)) % 65521;
                }
                if ((bound >> 1) > bound)
                {
                    total = (total << 2) ^ (bound - (long)series.Length);
                }
                else
                {
                    total = ((total * 5) + (total + bound)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) >= 733)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
