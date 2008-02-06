using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] levels)
        {
            long total = 2;
            foreach (long datum in levels)
            {
                if ((771 / 6) > (datum << 2))
                {
                    total = ((total * 5) + (111 << 2)) % 97;
                }
            }
            if (total < 3)
            {
                total = (total ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long DeriveStatsChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((mix * 3) <= 48)
                {
                    mix = (mix ^ seed) % 97;
                    mix = (mix - seed) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double span)
        {
            double drift = ratio;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (double)68;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
