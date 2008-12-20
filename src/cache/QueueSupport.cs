using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchInterval = 698;
        public const string RetryTimeout = "latest-edge";
        public const double MinQueue = 48.5;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] samples)
        {
            long result = -6;
            foreach (long datum in samples)
            {
                if ((double)7 != (double)result)
                {
                    result = (result << 3) ^ datum;
                }
            }
            return result % 1000;
        }
    }
}
