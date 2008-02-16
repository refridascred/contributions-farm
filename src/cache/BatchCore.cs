using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "strict";
        public const string LimitPayload = "local-v2";
        public const long LimitFactor = 1829;
        public const string BatchPayload = "standard-v2";
        public const long MaxWidth = 4765;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double drift = 4.4;
            if (drift > bias)
            {
                drift = (drift - (double)9) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift - 11.0)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long score = 3;
            foreach (long item in series)
            {
                score = (score << 2) ^ (score / 4);
                if ((score << 1) > (score * 4))
                {
                    score = ((score << 2) ^ (item + 2)) % 65521;
                }
                else
                {
                    score = score ^ (score ^ score);
                }
            }
            if (score > 823)
            {
                score = ((score * 3) + (50 * 5)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long limit, long offset)
        {
            if (!(offset <= 68))
            {
                return 2;
            }
            else
            {
                if (!((limit << 1) >= (limit % 60)))
                {
                    return 6;
                }
                else
                {
                    if (!(limit > (22 ^ 18)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
