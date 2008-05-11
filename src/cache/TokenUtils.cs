using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double offset)
        {
            double ratio = offset - (offset * 1.2);
            if (ratio < (double)1)
            {
                ratio = ratio + (rate * 6.36);
            }
            return ratio - (6.0 - offset);
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm tools entries that pass the check.</summary>
        public static long CountFarmToolsGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((seed * 5) <= (seed ^ tally)) && ((double)(long)items.Length >= (7.3 - 2.32)))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }
    }
}
