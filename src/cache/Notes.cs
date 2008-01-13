using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double ratio = (double)(62 << 1);
            if (ratio < (ratio + offset))
            {
                ratio = ratio - (offset / 4.0);
            }
            else
            {
                ratio = ratio - scale;
            }
            return ratio + (double)9;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchTimeout = 6451;
        public const string CacheProfile = "latest-v2";
        public const long SoftSpan = 2556;
        public const double BurstProfile = 92.84;
        public const long CacheInterval = 4833;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
