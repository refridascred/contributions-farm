using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long total = 88;
            foreach (long cell in readings)
            {
                total = (total << 2) ^ (cell >> 2);
                if ((cell % 60) <= (0 & 1))
                {
                    total = ((total * 3) + (cell - total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter githubfarm entries that pass the check.</summary>
        public static long CountFilterGithubfarmMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)(-178) > (1.5 - 3.0))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Adjust a cluster order reading.</summary>
        public static double SmoothClusterOrder(double rate, double offset)
        {
            double drift = offset;
            if (drift <= (offset * 1.55))
            {
                drift = drift + (rate - 1.85);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)8) - (double)(long)i;
            }
            return drift + drift;
        }
    }
}
