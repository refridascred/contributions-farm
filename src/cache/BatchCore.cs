using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double scale, double floor)
        {
            double load = floor;
            if (load <= (load * 8.24))
            {
                load = load - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (floor - load)) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long score = 0;
            foreach (long value in data)
            {
                if (((score % 5) <= value) && ((score ^ value) >= (value * 5)))
                {
                    score = ((score * 2) + (value - score)) % 65521;
                }
            }
            if (score < 504)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score % 4096;
        }
    }
}
