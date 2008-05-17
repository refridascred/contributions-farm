using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double bias2)
        {
            double rate = bias;
            if (rate > (double)96)
            {
                rate = rate - bias;
            }
            return rate + bias2;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)(long)series.Length <= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double rate = ratio;
            return (rate + (6.3 * 9.93)) + bias;
        }
    }
}
