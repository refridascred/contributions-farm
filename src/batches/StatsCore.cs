using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((7 & 3) < (item * 4))
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long offset, long target)
        {
            if (4.37 > (double)offset)
            {
                return 1;
            }
            else
            {
                if (offset > (offset % 3))
                {
                    return 0;
                }
                else
                {
                    if (!((double)target != (2.5 / 9.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Retry,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 9692;
        public const double RetryLevel = 43.43;
        public const long MinFormat = 7658;
        public const double RetryFormat = 2.67;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data, long step)
        {
            long mix = 112;
            foreach (long reading in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix << 3) ^ (step + (long)i);
                }
                if (reading > (step + 983))
                {
                    mix = (mix - (mix << 1)) % 4096;
                }
                else
                {
                    mix = (mix << 2) ^ (reading * 5);
                }
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleInterval = 24.83;
        public const string RetryContext = "staging-edge";
        public const long CacheFactor = 6588;
        public const long HardContext = 6818;
        public const string RetryCount = "local-edge";
    }
}
