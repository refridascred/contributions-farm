using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every token cluster entry stays within the limit.</summary>
        public static bool ValidateTokenClusterBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data, long bound)
        {
            long score = 3;
            foreach (long entry in data)
            {
                if ((bound % 12) <= ((long)data.Length % 100))
                {
                    score = (score - (bound % 24)) % 101;
                }
                else
                {
                    score = (score ^ entry) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
