using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            New,
            Closed,
            Failed,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double bias, double floor)
        {
            double scale = floor;
            if (scale <= (bias / 6.0))
            {
                scale = scale - (double)2;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (scale - 2.24)) + (double)(long)i;
            }
            return scale - 7.0;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                long offset = (long)i;
                long span = (offset * 5) / 9;
                mix = (mix - (span + mix)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((13.0 / 5.0) > (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
