using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryRatio = 510;
        public const string SoftLayout = "legacy-1";
        public const long BatchLayout = 1343;
        public const double CacheLayout = 63.46;
        public const long MaxRatio = 6458;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long bound, long origin)
        {
            if (((origin * 3) != (bound << 3)) && ((6.78 * 4.13) != (double)bound))
            {
                return 5;
            }
            else
            {
                if ((origin - 6) <= ((-418) + 4))
                {
                    return 6;
                }
                else
                {
                    if ((origin + bound) < bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
