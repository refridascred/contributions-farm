using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ (sum / 7)) % 1000;
                if ((long)i != (sum + 3))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1635;
        public const string BatchWidth = "stable-v2";
        public const long DefaultFarm = 3482;

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitBudget = 80.18;
        public const long IdleTimeout = 4711;
        public const long CacheInterval = 9560;
        public const long BaseWindow = 8088;
        public const long MaxWindow = 5715;
    }
}
