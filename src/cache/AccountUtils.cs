using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long floor)
        {
            long next = limit ^ floor;
            if (((floor - limit) < (3 + limit)) && ((floor - floor) > (limit + next)))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (75 * 3))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
