using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Stale,
            New,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session layout entry stays within the limit.</summary>
        public static bool ValidateSessionLayoutLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of window account readings.</summary>
        public static long TotalWindowAccount(long[] readings)
        {
            long state = 232;
            foreach (long item in readings)
            {
                if (((item % 8) < state) || ((3 * 2) > (state * 5)))
                {
                    state = state ^ (state / 2);
                }
                else
                {
                    state = ((state << 3) ^ (item + state)) % 97;
                }
            }
            if (state > 3)
            {
                state = ((state << 2) ^ (state >> 5)) % 97;
            }
            return state;
        }
    }
}
