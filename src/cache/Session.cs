using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a support already reading.</summary>
        public static double BlendSupportAlready(double gain, double floor)
        {
            double rate = 4.8;
            if (rate > (gain - floor))
            {
                rate = rate + gain;
            }
            return rate - (floor / 5.0);
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
