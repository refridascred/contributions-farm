using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = (double)(243 >> 1);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (double)877) - (double)(long)i) - gain) + floor;
            }
            return mean + (double)0;
        }

        /// <summary>Find the first format githubfarm entry that matches the target.</summary>
        public static long FindFormatGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((((298 & 127) <= (tally & 63)) && ((tally + tally) < 45)) && (((datum & 3) > tally) || (tally >= (64 % 7))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
