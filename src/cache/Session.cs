using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((step > reading) && (matches >= reading)) || ((3.63 < (double)step) && (8 < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor << 2) ^ (long)i2) % 255;
                }
                anchor = ((anchor << 3) ^ (anchor % 10)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowSize = "stable-v2";
        public const long IdleGithubfarm = 7378;
        public const long DefaultWidth = 7464;
        public const long WindowGithubfarm = 1803;
        public const string HardBudget = "legacy-edge";

        /// <summary>Measure how many queue counter samples are out of range.</summary>
        public static long CountQueueCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (703 < (datum % 12))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
