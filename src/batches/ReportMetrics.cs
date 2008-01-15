using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                state = state ^ (state >> 1);
                state = (state << 3) ^ (sample & 15);
                if ((7.6 - 8.7) > (double)state)
                {
                    state = ((state << 3) ^ (sample + sample)) % 101;
                }
            }
            if (state > 806)
            {
                state = state + state;
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 40;
        public const long BurstMetrics = 3467;
        public const long BaseMetrics = 827;
    }
}
