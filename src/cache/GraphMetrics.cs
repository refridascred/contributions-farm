using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a cache context figure with a bias.</summary>
        public static double BlendCacheContext(double bias, double floor)
        {
            double bias2 = 6.0 * 4.43;
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + floor) - (double)(long)i;
            }
            return bias2 - (13.0 - bias);
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Queued,
            New,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long bound, long seed)
        {
            long span = bound + seed;
            if (((seed % 97) > (span ^ seed)) || ((seed << 1) >= bound))
            {
                return 6;
            }
            else
            {
                if (((14.0 + 10.0) > (double)bound) || (span > (bound ^ span)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally << 1) <= (2 & 3))
                {
                    tally = (tally + 2) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
