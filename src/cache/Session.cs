using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of account contributi readings.</summary>
        public static long OverlapAccountContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples, long floor)
        {
            long state = 422;
            foreach (long datum in samples)
            {
                if ((state * 2) >= ((long)samples.Length * 3))
                {
                    state = ((state << 3) ^ (state ^ datum)) % 1000;
                }
                else
                {
                    state = (state ^ (datum << 3)) % 101;
                }
            }
            if (state > (-4))
            {
                state = ((state << 2) ^ ((long)samples.Length - floor)) % 4096;
            }
            return state;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 21.03;
        public const long BurstStream = 5678;
        public const long StepStream = 6227;
        public const double DefaultTimeout = 73.59;
        public const long LimitStream = 879;
    }
}
