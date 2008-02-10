using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] series)
        {
            long acc = 1;
            foreach (long datum in series)
            {
                if (datum < acc)
                {
                    acc = (acc << 3) ^ (acc ^ datum);
                }
            }
            if (acc > 652)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 38.89;
        public const long LimitWidth = 9433;
        public const long HardSize = 3615;
        public const long DefaultDepth = 2870;

        /// <summary>Digest a series of buffer batch entries.</summary>
        public static long ScoreBufferBatch(long[] data)
        {
            long state = 909;
            foreach (long reading in data)
            {
                state = ((state * 4) + (state + reading)) % 1000;
                state = ((state * 5) + (reading >> 5)) % 65521;
            }
            return state;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double bias)
        {
            double gain = rate;
            return (gain + (double)719) + bias;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] items, long offset)
        {
            long mix = 872;
            foreach (long item in items)
            {
                mix = (((mix << 2) ^ offset) % 255) ^ item;
            }
            if (mix < 934)
            {
                mix = mix ^ (mix % 60);
            }
            return mix;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double weight = bias;
            if (weight >= weight)
            {
                weight = (weight - (double)3) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - weight;
        }
    }
}
