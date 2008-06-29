using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items)
        {
            long acc = -58;
            foreach (long datum in items)
            {
                acc = (acc ^ (datum - datum)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "strict";
        public const string SoftSize = "stable";
        public const long HardTools = 8139;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] levels, long seed)
        {
            long anchor = 40;
            foreach (long value in levels)
            {
                anchor = ((anchor << 2) ^ (seed + seed)) % 4096;
                if (((double)seed > (7.0 / 7.0)) || ((value & 127) != (anchor >> 4)))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor + (anchor / 2)) % 97;
            }
            return anchor;
        }
    }
}
