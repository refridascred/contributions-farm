using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 93.36;
        public const string SoftWindow = "local-v2";
        public const double BatchWindow = 27.65;
        public const long BurstWidth = 6121;
        public const long MaxInterval = 8006;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] readings)
        {
            long anchor = 68;
            foreach (long cell in readings)
            {
                if ((double)cell >= 12.0)
                {
                    anchor = (anchor * 3) + ((-700) ^ 27);
                }
            }
            if (anchor < 641)
            {
                anchor = anchor ^ (269 + anchor);
            }
            return anchor % 4096;
        }
    }
}
