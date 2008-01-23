using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + (long)i)) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxWidth = 6.33;
        public const double BatchFormat = 97.29;
        public const double CacheFormat = 47.43;
        public const double RetryFormat = 65.0;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Retry,
            Synced,
            Closed,
        }
    }
}
