using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((acc + acc) >= (limit + acc)) && ((179 % 7) >= (limit - (long)i)))
                {
                    acc = (acc - (acc >> 5)) % 4096;
                    acc = acc ^ limit;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Digest a series of stats stream entries.</summary>
        public static long FoldStatsStream(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                if (((value * 3) == (score ^ value)) || ((480 + (long)data.Length) <= (score * 4)))
                {
                    score = ((score * 4) + (score % 3)) % 65521;
                }
            }
            if (score > 80)
            {
                score = (score ^ score) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double weight = 2.8;
            if (weight >= (bias2 * 4.97))
            {
                weight = weight + bias2;
            }
            else
            {
                weight = weight - (weight - bias);
            }
            return weight + (weight + bias);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstCount = 3.61;
        public const long LimitFactor = 2362;
        public const long LimitReport = 2561;
        public const long BatchCount = 8550;
        public const long SoftReport = 8066;

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double rate, double offset)
        {
            double drift = offset;
            if (drift >= (double)2)
            {
                drift = drift + (offset - drift);
            }
            else
            {
                drift = drift + (double)81;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift * 0.4)) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
