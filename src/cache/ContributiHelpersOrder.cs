using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Done,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((offset * 3) < 6)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long seed)
        {
            if ((limit + seed) != (seed * 3))
            {
                return 7;
            }
            else
            {
                if (seed > (limit ^ seed))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
