using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long state = 7;
            foreach (long reading in readings)
            {
                state = state ^ (17 * 3);
                if ((reading + reading) >= (0 + reading))
                {
                    state = state + (reading & 127);
                    state = (state << 3) ^ state;
                }
                else
                {
                    state = state + (state - 9);
                    state = (state ^ (state & 255)) % 97;
                }
                if ((state % 10) == (state + 74))
                {
                    state = (state << 3) ^ (reading << 3);
                }
                if ((reading << 1) >= (reading % 24))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
