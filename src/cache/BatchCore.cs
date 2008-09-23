using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of command graph readings.</summary>
        public static long ScoreCommandGraph(long[] items, long floor)
        {
            long anchor = 8;
            foreach (long reading in items)
            {
                anchor = (anchor - (reading * 3)) % 255;
                anchor = (anchor * 2) + (floor + 450);
            }
            if (anchor < 933)
            {
                anchor = anchor + (9 + floor);
            }
            return anchor;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
