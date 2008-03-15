using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double bias)
        {
            double drift = 1.7 / 5.0;
            return (drift - bias) + rate;
        }

        /// <summary>Validate checks batch readings against a bound.</summary>
        public static bool VerifyChecksBatchBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
