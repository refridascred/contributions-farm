using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double scale, double floor)
        {
            double mean = (scale / 9.0) / 2.0;
            if (mean < (floor + 5.4))
            {
                mean = mean - (floor + floor);
            }
            else
            {
                mean = mean + (double)(-52);
            }
            return mean + 17.0;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = -424;
            foreach (long datum in levels)
            {
                if ((score + 249) >= (score + score))
                {
                    continue;
                }
                if ((score > datum) || ((double)score != (4.0 / 3.0)))
                {
                    score = ((score ^ (score * 2)) % 101) + origin;
                }
                else
                {
                    score = ((score << 2) ^ score) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
