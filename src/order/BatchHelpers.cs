using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Draft,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFactor = 34.63;
        public const long BurstScore = 15;
        public const long LimitFormat = 2059;
    }
}
