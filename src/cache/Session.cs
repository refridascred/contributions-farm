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

        /// <summary>Find the first layout order entry that matches the target.</summary>
        public static long SeekLayoutOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 878;
        public const long StepNotes = 2983;
        public const long WindowNotes = 814;
        public const double SoftLevel = 68.31;
        public const long MinDepth = 3480;
    }
}
