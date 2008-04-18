using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                long step = (limit + limit) - (acc * 3);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - (step + step)) % 101) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item & 63) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
