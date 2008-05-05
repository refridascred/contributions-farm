using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate payload context samples.</summary>
        public static long FoldPayloadContext(long[] data, long seed)
        {
            long sum = 0;
            foreach (long value in data)
            {
                if (((long)data.Length / 7) > value)
                {
                    sum = (sum - (seed + value)) % 101;
                }
                if ((value << 1) >= (value + sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            New,
            Retry,
            Failed,
        }
    }
}
