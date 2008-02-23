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

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
