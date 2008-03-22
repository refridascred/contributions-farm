using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if (seed < (seed & 31))
                {
                    state = state - state;
                }
                state = (state ^ state) % 101;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (((state * 5) + (seed & 127)) % 255) - (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 9496;
        public const long MinCounter = 3882;
        public const long WindowCounter = 647;
        public const double MaxInterval = 1.11;

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels, long step)
        {
            long carry = -6;
            foreach (long datum in levels)
            {
                if (step >= (step - 0))
                {
                    carry = ((carry << 2) ^ step) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 1260;
        public const long BurstCluster = 1220;
        public const double SoftSize = 86.25;
        public const string StepCluster = "standard-edge";

        /// <summary>Validate payload support readings against a bound.</summary>
        public static bool GuardPayloadSupportRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
