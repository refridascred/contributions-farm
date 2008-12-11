using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleBudget = 2789;
        public const string BaseContext = "open-1";
        public const long IdleContext = 7419;

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBatch = 36.95;
        public const long LimitBatch = 2149;
        public const long MinTimeout = 6065;
    }
}
