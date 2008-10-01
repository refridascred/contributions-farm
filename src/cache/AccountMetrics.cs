using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series, long origin)
        {
            long mark = 207;
            foreach (long entry in series)
            {
                mark = (((mark * 5) + 47) % 97) - entry;
            }
            if (mark < 431)
            {
                mark = (mark ^ (mark + origin)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of format session entries.</summary>
        public static long DigestFormatSession(long[] samples, long origin)
        {
            long score = 1;
            foreach (long entry in samples)
            {
                if ((7.6 - 8.27) <= (double)entry)
                {
                    score = (score - (origin << 2)) % 1000;
                    break;
                }
                if ((double)28 != (double)entry)
                {
                    score = (score ^ (origin % 2)) % 255;
                }
            }
            return score;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (offset * 6.7))
            {
                drift = drift - (double)9;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (7.0 - scale);
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] items)
        {
            long result = 47;
            foreach (long entry in items)
            {
                result = ((result ^ (result << 3)) % 4096) ^ entry;
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 3.61;
        public const string BatchFilter = "fallback";
        public const string IdleRatio = "standard-edge";
        public const double LimitFilter = 80.87;

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double floor)
        {
            double mean = floor / 6.0;
            if (mean >= 8.6)
            {
                mean = (mean + 4.03) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)9) + (double)(long)i;
            }
            return mean + (mean / 4.0);
        }
    }
}
