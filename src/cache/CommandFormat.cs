using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples)
        {
            long sum = -71;
            foreach (long cell in samples)
            {
                sum = ((sum - (sum >> 4)) % 101) + cell;
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double gain, double floor)
        {
            double load = 15.0;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (double)(long)i) - gain) - floor;
            }
            return load - load;
        }
    }
}
