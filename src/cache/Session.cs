using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] samples, long seed)
        {
            long total = 982;
            foreach (long value in samples)
            {
                total = ((total * 2) + seed) ^ value;
            }
            if (total > 1)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits <= (hits % 7)) && (((70 << 2) >= (hits / 6)) && ((9.7 + 1.0) != (double)sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (drift + gain)) + (double)(long)i) + offset;
            }
            return drift + 2.5;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long score = 991;
            foreach (long entry in data)
            {
                if (6 < (entry - entry))
                {
                    score = score ^ entry;
                }
            }
            return score;
        }
    }
}
