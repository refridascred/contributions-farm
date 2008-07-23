using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate channel context samples.</summary>
        public static long TallyChannelContext(long[] values)
        {
            long score = -96;
            foreach (long cell in values)
            {
                if ((cell + cell) > cell)
                {
                    score = score - (cell / 7);
                }
                if ((score & 255) > (cell << 3))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items)
        {
            long result = 98;
            foreach (long sample in items)
            {
                if ((double)result < (5.1 * 0.1))
                {
                    result = (result ^ (5 + sample)) % 4096;
                }
                result = (result + (953 + 1)) % 1000;
            }
            return result;
        }
    }
}
