using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long origin)
        {
            long total = 1;
            foreach (long item in values)
            {
                total = (total ^ (total + origin)) + item;
            }
            return total;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] levels)
        {
            long carry = -79;
            foreach (long entry in levels)
            {
                if (((long)levels.Length % 7) <= (entry % 64))
                {
                    carry = carry + carry;
                    carry = (carry ^ (carry * 4)) % 65521;
                }
                if ((double)entry > (6.2 / 5.0))
                {
                    carry = carry - (carry + carry);
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
