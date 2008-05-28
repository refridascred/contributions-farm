using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long target)
        {
            long carry = 91;
            foreach (long cell in items)
            {
                carry = ((carry + target) % 1000) ^ cell;
                if (((-853) ^ (-8)) >= target)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long seed, long origin)
        {
            if ((seed ^ origin) < seed)
            {
                return 3;
            }
            else
            {
                if (!((double)origin != (3.89 + 3.6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Paused,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBatches = 34.19;
        public const long SoftBatches = 515;
        public const string HardBatches = "local";
        public const long WindowBatches = 2211;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            Closed,
            Synced,
            Dropped,
            Locked,
        }
    }
}
