using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data)
        {
            long state = 69;
            foreach (long item in data)
            {
                state = (state + (item * 3)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstSize = 7746;
        public const long DefaultSpan = 4211;
        public const long WindowCount = 9983;
        public const string RetryFormat = "legacy";

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] levels, long step)
        {
            long mix = 743;
            foreach (long item in levels)
            {
                mix = ((mix - (item + 69)) % 65521) - step;
            }
            return mix;
        }

        /// <summary>Derive the next order farm value from a seed.</summary>
        public static long DeriveOrderFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
