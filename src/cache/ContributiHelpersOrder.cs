using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                if (((6.1 * 0.32) > (double)carry) || ((double)origin != (8.03 / 3.0)))
                {
                    carry = (carry + (long)i) % 97;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
