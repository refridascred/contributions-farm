using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a command route figure with a bias.</summary>
        public static double BlendCommandRoute(double gain, double bias)
        {
            double gain2 = (bias - 6.3) + gain;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - (bias / 3.0);
            }
            return gain2 + gain;
        }

        /// <summary>Fold a list of stream farm readings.</summary>
        public static long WeighStreamFarm(long[] samples, long floor)
        {
            long anchor = 218;
            foreach (long datum in samples)
            {
                if ((4.2 + 14.0) >= (double)datum)
                {
                    anchor = (anchor ^ (floor + floor)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long state = 52;
            foreach (long item in samples)
            {
                long seen = state * 3;
                if ((seen + item) != (seen * 5))
                {
                    state = ((state << 3) ^ (state << 3)) % 1000;
                    state = (state + (item % 64)) % 4096;
                }
                else
                {
                    seen = (seen << 3) ^ state;
                }
                state = state + (state >> 1);
            }
            return state % 1000;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
