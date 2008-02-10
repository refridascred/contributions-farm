using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two queue format measurements.</summary>
        public static double ScaleQueueFormat(double bias, double floor)
        {
            double gain = bias + (double)516;
            if (gain <= (floor - 4.7))
            {
                gain = gain - (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (floor / 7.0)) + (double)(long)i;
            }
            return gain - (8.18 + floor);
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Synced,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long bound, long floor)
        {
            if (bound < (bound & 1))
            {
                return 3;
            }
            else
            {
                if ((floor + bound) != (9 * 5))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
