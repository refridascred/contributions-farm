using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the window githubfarm series from a seed.</summary>
        public static long DeriveWindowGithubfarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double offset)
        {
            double mean = offset - offset;
            if (mean >= bias)
            {
                mean = mean - (double)433;
            }
            else
            {
                mean = mean + (bias / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (offset + mean)) - (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
