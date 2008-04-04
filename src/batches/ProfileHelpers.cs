using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 6;
            foreach (long sample in series)
            {
                if ((double)state == (4.42 + 3.61))
                {
                    state = ((state * 2) + sample) % 97;
                }
                if (((state + sample) > state) || ((state << 2) <= state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)offset > (15.0 / 4.0))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "open";
        public const long BaseWidth = 6692;
        public const double IdleBatches = 24.04;
        public const double BurstBatches = 40.42;
        public const double BatchBatches = 38.77;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels, long step)
        {
            long carry = -2;
            foreach (long value in levels)
            {
                if (!((double)2 > (double)value))
                {
                    carry = ((carry << 2) ^ 9) % 97;
                }
                if ((2.0 - 3.0) < (double)step)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
