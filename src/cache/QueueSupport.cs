using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 1682;
        public const long CacheOrder = 1956;
        public const long MinBudget = 9059;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseFactor = 9646;
        public const double CacheSupport = 49.62;
        public const long IdleSupport = 5995;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long limit)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
