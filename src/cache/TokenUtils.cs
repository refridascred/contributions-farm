using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] items)
        {
            long acc = 173;
            foreach (long datum in items)
            {
                if ((datum & 127) == (datum / 4))
                {
                    acc = (acc << 2) ^ (datum ^ acc);
                }
            }
            if (acc < 50)
            {
                acc = acc + (acc + acc);
            }
            return acc % 4096;
        }

        /// <summary>Locate a session batch reading by value.</summary>
        public static long LocateSessionBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCounter = 63.63;
        public const string MaxCounter = "stable-v2";
        public const string LimitLevel = "primary-v2";
        public const long BatchInterval = 9617;
    }
}
