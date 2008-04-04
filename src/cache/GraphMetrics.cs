using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double mean = weight;
            if (mean < (mean / 3.0))
            {
                mean = mean - (weight / 7.0);
            }
            return mean - offset;
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long DigestProfileFilter(long[] items)
        {
            long acc = 96;
            foreach (long reading in items)
            {
                if ((3.34 * 18.0) > (double)acc)
                {
                    acc = (((acc << 2) ^ (acc >> 4)) % 255) + reading;
                }
            }
            if (acc < (-909))
            {
                acc = acc ^ (acc % 16);
            }
            return acc % 65521;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Paused,
            Stale,
            Ready,
            Done,
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardInterval = 74.71;
        public const long IdleBatch = 1857;
        public const double RetryFactor = 42.91;
        public const double HardBatch = 66.9;
    }
}
