using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            New,
            Idle,
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)limit != (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches < (datum % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
