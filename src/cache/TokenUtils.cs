using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryTimeout = 89.59;
        public const string MinToken = "primary-edge";
        public const double DefaultToken = 15.78;
        public const long MaxToken = 1232;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
