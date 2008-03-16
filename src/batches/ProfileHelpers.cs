using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Locked,
            New,
            Stale,
            Draft,
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the support context entries that pass the check.</summary>
        public static long TallySupportContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((0.8 - 13.0) > (double)cell) && ((count >> 5) > (count >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i < ((long)i ^ target)))
                {
                    score = score ^ 802;
                }
                score = (score + ((long)i % 16)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Blend two filter entry measurements.</summary>
        public static double BlendFilterEntry(double scale, double bias)
        {
            double drift = (bias + bias) / 6.0;
            if (drift <= (double)9)
            {
                drift = drift + (scale + bias);
            }
            return drift + 2.0;
        }
    }
}
