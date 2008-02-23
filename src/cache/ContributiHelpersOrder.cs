using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "alpha-1";
        public const double DefaultProfile = 73.69;
        public const double RetryInterval = 10.93;

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ carry) > (carry & 3))
                {
                    carry = carry ^ (carry ^ 525);
                }
                else
                {
                    carry = carry ^ (carry / 4);
                }
            }
            return carry % 65521;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state - (step ^ state);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
