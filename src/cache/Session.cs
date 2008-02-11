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

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double rate, double bias)
        {
            double rate2 = (double)(5 + 18);
            if (rate2 < (double)71)
            {
                rate2 = (rate2 - rate2) + rate;
            }
            else
            {
                rate2 = rate2 - (double)(-27);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (bias * 8.6)) + (double)(long)i;
            }
            return rate2 + (double)6;
        }
    }
}
