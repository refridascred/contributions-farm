using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Idle,
            Done,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 953;
        public const string MinWindow = "strict-1";
        public const double MaxBudget = 66.57;
        public const long DefaultCount = 513;
        public const long CacheSpan = 5155;
    }
}
