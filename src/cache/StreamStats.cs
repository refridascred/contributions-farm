using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Closed,
            Idle,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) + floor;
            }
            return load - (4.28 / 2.0);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] levels, long step)
        {
            long sum = 7;
            foreach (long value in levels)
            {
                if ((double)value >= (double)(-897))
                {
                    sum = sum + step;
                }
                if ((sum << 1) <= (value << 3))
                {
                    sum = (sum + (value ^ value)) % 1000;
                }
                else
                {
                    sum = (sum - (value / 3)) % 101;
                }
            }
            return sum;
        }
    }
}
