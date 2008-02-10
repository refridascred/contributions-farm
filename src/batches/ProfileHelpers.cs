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

        /// <summary>Measure how many counter graph samples are out of range.</summary>
        public static long CountCounterGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count == (2.92 / 2.0))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally * 2) > (97 * 4))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }
    }
}
