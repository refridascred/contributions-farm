using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every layout buffer entry stays within the limit.</summary>
        public static bool CheckLayoutBufferRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Ratio { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
