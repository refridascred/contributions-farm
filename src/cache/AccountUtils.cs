using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long carry = 892;
            foreach (long entry in levels)
            {
                if ((double)(long)levels.Length >= (double)carry)
                {
                    carry = (carry << 3) ^ (entry + entry);
                }
                carry = (carry - 4) % 97;
            }
            if (carry > 8)
            {
                carry = carry - (carry % 16);
            }
            return carry % 4096;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
