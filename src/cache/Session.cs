using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every token session entry stays within the limit.</summary>
        public static bool CheckTokenSessionBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                if ((sample + 499) == (sample + sample))
                {
                    total = ((total * 3) + (sample - total)) % 101;
                }
                else
                {
                    total = (total - (sample + total)) % 65521;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheDepth = 57.94;
        public const long StepSize = 6878;
        public const string CacheBatch = "cached-1";
        public const long WindowInterval = 1782;
        public const long HardDepth = 8283;
    }
}
