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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
