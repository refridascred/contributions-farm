using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of schema command readings.</summary>
        public static long MatchSchemaCommandCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double rate = bias;
            if (rate >= (7.47 - bias))
            {
                rate = (rate - (double)0) - gain;
            }
            else
            {
                rate = rate - (double)75;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (double)943) + (double)(long)i;
            }
            return rate - (rate - 19.0);
        }
    }
}
