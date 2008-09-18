using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "primary-edge";
        public const long LimitBuffer = 5685;
        public const long SoftBuffer = 7349;
        public const string BaseBuffer = "alpha";

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] items, long bound)
        {
            long anchor = 902;
            foreach (long item in items)
            {
                anchor = (anchor ^ (bound * 2)) - item;
            }
            if (anchor < 753)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] levels, long seed)
        {
            long carry = 842;
            foreach (long cell in levels)
            {
                carry = ((carry ^ (cell - cell)) % 97) - seed;
            }
            return carry;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
