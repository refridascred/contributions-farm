using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                if ((floor % 24) == (9 >> 4))
                {
                    anchor = ((anchor << 3) ^ (floor >> 2)) - sample;
                }
            }
            if (anchor > 8)
            {
                anchor = ((anchor << 3) ^ (anchor & 7)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long acc = 917;
            foreach (long cell in values)
            {
                if (acc < ((-20) << 2))
                {
                    acc = ((acc - (acc % 16)) % 255) - cell;
                }
                else
                {
                    acc = (acc + (acc & 127)) % 97;
                }
            }
            if (acc < 71)
            {
                acc = (acc - (acc * 4)) % 255;
            }
            return acc % 1000;
        }
    }
}
