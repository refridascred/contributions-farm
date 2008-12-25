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

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
