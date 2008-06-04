using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate record support readings against a bound.</summary>
        public static bool CheckRecordSupportRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Paused,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 72.82;
        public const long RetryFactor = 3714;
        public const long MaxSchema = 5932;
        public const string BaseSchema = "fallback";
    }
}
