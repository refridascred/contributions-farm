using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every editor account entry stays within the limit.</summary>
        public static bool VerifyEditorAccountLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((503 + result) == (limit + result))
                {
                    result = (result + (limit & 1)) % 101;
                    continue;
                }
                else
                {
                    result = result + (15 - result);
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
