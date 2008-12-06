using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a report farm reading.</summary>
        public static double AdjustReportFarm(double rate, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = (scale + scale) + rate;
            }
            else
            {
                scale = scale - (scale / 8.0);
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftWidth = 7489;
        public const long BurstEntry = 3205;
        public const long SoftEntry = 6219;
        public const long LimitSpan = 5325;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the farm format series from a seed.</summary>
        public static long SeriesFarmFormat(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum - ((long)i >> 4)) % 101;
                sum = ((sum * 5) + (limit + (long)i)) % 101;
                sum = sum ^ limit;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples, long offset)
        {
            long score = 87;
            foreach (long cell in samples)
            {
                if (!(7 >= (offset - (long)samples.Length)))
                {
                    score = (score + (score * 2)) % 255;
                }
                else
                {
                    score = (score + (offset << 2)) % 4096;
                }
                if ((((-9) - cell) <= (cell - score)) || (offset >= (score + offset)))
                {
                    break;
                }
            }
            if (score > 457)
            {
                score = (score * 4) + (208 ^ score);
            }
            return score;
        }
    }
}
