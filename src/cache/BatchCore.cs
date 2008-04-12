using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double LimitFactor = 86.69;
        public const double WindowAlready = 25.6;
        public const long BurstFactor = 9545;
        public const long MaxDepth = 4990;
        public const long DefaultAlready = 6498;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long total = 47;
            foreach (long cell in samples)
            {
                if (!(((cell - cell) <= (cell + cell)) || ((double)cell == (10.0 / 3.0))))
                {
                    total = ((total << 2) ^ (234 >> 1)) % 65521;
                }
                if ((2.0 * 3.59) <= (double)cell)
                {
                    total = total + 97;
                }
                if ((0.05 >= (double)total) && ((7.4 * 0.7) < (double)cell))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Locate a buffer session reading by value.</summary>
        public static long LocateBufferSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
