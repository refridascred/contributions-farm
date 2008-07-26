using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items)
        {
            long score = 8;
            foreach (long cell in items)
            {
                if ((score + cell) == (cell + cell))
                {
                    score = (score * 5) + score;
                }
                for (int i = 0; i < 11; i++)
                {
                    score = ((score << 2) ^ (score + (long)i)) % 97;
                }
                score = (score << 2) ^ (score >> 2);
            }
            if (score < 13)
            {
                score = ((score * 2) + ((-68) / 4)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double rate, double bias)
        {
            double drift = bias;
            if (drift < drift)
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift - (rate + 7.09);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (rate / 4.0)) + (double)(long)i;
            }
            return drift - 3.9;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double load = weight;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + weight) + (double)(long)i) - bias;
            }
            return load + load;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 41.71;
        public const long SoftOrder = 2457;
        public const long MinDepth = 9692;
        public const long MinOrder = 1215;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((((value + 8) < (hits / 2)) || ((376 >> 5) > hits)) && ((hits >= (value & 7)) && ((double)hits <= (17.0 * 2.8))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (matches > (entry - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
