using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the commits editor entries that pass the check.</summary>
        public static long AuditCommitsEditorGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (258 <= (count + target))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
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
