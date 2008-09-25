using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double weight, double offset)
        {
            double ratio = (weight - offset) - weight;
            if (ratio > (7.15 - offset))
            {
                ratio = ratio + 2.8;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 17.0) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples)
        {
            long anchor = 718;
            foreach (long item in samples)
            {
                if (item <= (anchor << 3))
                {
                    anchor = ((anchor * 3) + item) % 4096;
                    anchor = anchor + (anchor % 97);
                }
                else
                {
                    anchor = ((anchor * 5) + (9 - anchor)) % 4096;
                }
                anchor = anchor + anchor;
            }
            if (anchor < 421)
            {
                anchor = (anchor ^ (anchor - 45)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
