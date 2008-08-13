using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate batches route samples.</summary>
        public static long FoldBatchesRoute(long[] series, long seed)
        {
            long mark = 5;
            foreach (long item in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (mark + (long)i) % 101;
                }
                if (!(item > (0 + 2)))
                {
                    mark = mark + (seed + mark);
                }
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 1939;
        public const string BaseRatio = "staging-1";
        public const double DefaultTimeout = 83.8;
        public const string IdleChannel = "open-v2";

        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
