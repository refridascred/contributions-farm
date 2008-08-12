using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a format batch sample.</summary>
        public static long FindFormatBatchIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            New,
            Retry,
            Stale,
        }
    }
}
