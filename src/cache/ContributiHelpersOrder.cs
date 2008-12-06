using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] readings, long seed)
        {
            long result = 50;
            foreach (long value in readings)
            {
                if ((1.8 > (double)result) && ((5.61 / 7.0) == (double)value))
                {
                    result = result - (seed + seed);
                }
            }
            return result;
        }
    }
}
