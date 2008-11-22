using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell >= (tally * 5))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long bound, long step)
        {
            if (bound < (step ^ (-161)))
            {
                return 5;
            }
            else
            {
                if ((8.0 / 2.0) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
