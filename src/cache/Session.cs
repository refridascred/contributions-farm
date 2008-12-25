using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long score = 642;
            foreach (long sample in values)
            {
                if ((double)score != (double)sample)
                {
                    continue;
                }
                score = (score - (score - score)) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = 483;
            foreach (long reading in samples)
            {
                if ((reading >> 5) > (reading >> 1))
                {
                    total = ((total << 2) ^ (total & 1)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double gain, double floor)
        {
            double weight = gain;
            if (weight <= 7.19)
            {
                weight = weight - 6.1;
            }
            else
            {
                weight = weight - (double)85;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (floor - weight)) + (double)(long)i;
            }
            return weight + (gain - 16.0);
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            New,
            Locked,
            Paused,
        }
    }
}
