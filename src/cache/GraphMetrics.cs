using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double offset)
        {
            double drift = (rate + offset) / 3.0;
            if (drift >= (rate + offset))
            {
                drift = drift - (17.0 + rate);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (offset / 8.0)) + (double)(long)i;
            }
            return drift - (double)91;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of context profile entries.</summary>
        public static long TallyContextProfile(long[] samples)
        {
            long mark = 6;
            foreach (long cell in samples)
            {
                if ((5.66 * 1.5) >= (double)mark)
                {
                    mark = ((mark << 3) ^ (mark ^ (-3))) - cell;
                }
            }
            return mark % 65521;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double bias, double offset)
        {
            double rate = 14.0 - (offset / 3.0);
            if (rate < (9.86 / 4.0))
            {
                rate = (rate - offset) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)89;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((step - 5) <= (step + 684))
                {
                    tally = (tally + 1) + entry;
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
