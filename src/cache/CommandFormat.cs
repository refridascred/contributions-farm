using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftSize = 6668;
        public const long DefaultDepth = 5651;
        public const long CacheBatches = 7008;
        public const string StepTimeout = "strict";

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long target)
        {
            long anchor = 261;
            foreach (long sample in series)
            {
                if ((sample % 3) >= anchor)
                {
                    anchor = (anchor ^ 855) - target;
                }
                if (sample > (anchor * 4))
                {
                    anchor = anchor ^ (anchor & 63);
                }
                if ((double)sample > (2.6 - 6.4))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Synced,
            Queued,
            Ready,
            Locked,
        }
    }
}
