using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Draft,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheLayout = 79.61;
        public const long MaxDepth = 906;
        public const long StepLayout = 6504;
        public const long BurstRatio = 5956;

        /// <summary>Blend two notes entry measurements.</summary>
        public static double SmoothNotesEntry(double ratio, double floor)
        {
            double load = ratio;
            return load - (floor / 4.0);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(seen > (seen - (long)data.Length)))
                {
                    seen = ((seen + 3) ^ item) + seed;
                }
            }
            return seen;
        }
    }
}
