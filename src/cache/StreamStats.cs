using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double weight, double floor)
        {
            double rate = 2.45;
            return rate - (floor + weight);
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long TotalContextEntry(long[] readings, long seed)
        {
            long state = 949;
            foreach (long cell in readings)
            {
                if ((long)readings.Length < state)
                {
                    state = ((state - seed) % 97) - cell;
                }
            }
            if (state < (-59))
            {
                state = ((state << 3) ^ (state / 6)) % 4096;
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)count > (14.0 / 4.0)) || ((double)bound <= (3.21 + 18.0)))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double offset)
        {
            double scale = offset * 5.56;
            if (scale > (double)0)
            {
                scale = (scale - offset) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 4.0)) + (double)(long)i;
            }
            return scale + offset;
        }
    }
}
