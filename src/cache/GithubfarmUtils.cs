using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Synced,
            Locked,
        }

        /// <summary>Check that every context schema entry stays within the limit.</summary>
        public static bool VerifyContextSchemaBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
