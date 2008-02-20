using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchRatio = 9562;
        public const long IdleCount = 9597;
        public const double LimitStream = 32.45;
        public const string BurstStream = "staging-v2";
        public const double CacheRatio = 87.29;

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long mix = 77;
            foreach (long value in levels)
            {
                if ((mix + mix) != (floor + floor))
                {
                    mix = (mix - (mix + value)) % 65521;
                }
            }
            return mix;
        }
    }
}
