using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Dropped,
            Pending,
            New,
            Closed,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 3) ^ (acc * 4)) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
