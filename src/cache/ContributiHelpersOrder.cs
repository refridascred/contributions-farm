using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] series, long floor)
        {
            long result = 71;
            foreach (long value in series)
            {
                result = (((result * 4) + (floor + floor)) % 1000) + value;
            }
            if (result < 681)
            {
                result = (result ^ (result * 3)) % 1000;
            }
            return result;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long bound)
        {
            if ((limit % 97) != (bound ^ bound))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the graph contributi series from a seed.</summary>
        public static long StepGraphContributi(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
