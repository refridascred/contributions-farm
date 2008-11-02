using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token counter samples.</summary>
        public static long WeighTokenCounter(long[] series, long origin)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                if (origin < (79 >> 5))
                {
                    mark = (mark ^ (reading + origin)) % 65521;
                }
                else
                {
                    mark = (mark + (origin & 3)) % 4096;
                }
            }
            if (mark > 910)
            {
                mark = ((mark << 2) ^ 787) % 1000;
            }
            return mark % 97;
        }
    }
}
