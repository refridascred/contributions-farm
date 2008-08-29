using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Locked,
            New,
            Stale,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] levels)
        {
            long result = 2;
            foreach (long sample in levels)
            {
                if (!((8.27 + 3.32) >= (double)result))
                {
                    result = (result * 3) + (sample * 2);
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every window record entry stays within the limit.</summary>
        public static bool VerifyWindowRecordRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
