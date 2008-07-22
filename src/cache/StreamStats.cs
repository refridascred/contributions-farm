using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long floor)
        {
            long mix = -98;
            foreach (long entry in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix ^ (317 << 1)) % 97) ^ (long)i;
                }
                if (entry >= (mix * 2))
                {
                    mix = (mix + (323 + floor)) % 1000;
                }
                else
                {
                    mix = ((mix * 3) + (5 << 2)) % 97;
                }
                if ((mix + entry) <= (-8))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Project the next graph contributi value.</summary>
        public static double ScaleGraphContributi(double ratio, double offset)
        {
            double rate = 0.82;
            if (rate >= (double)7)
            {
                rate = rate + (rate + offset);
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (7.01 + rate);
        }
    }
}
