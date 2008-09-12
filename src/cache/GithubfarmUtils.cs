using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "alpha-v2";
        public const double CacheFactor = 81.78;
        public const string CacheFarm = "open-edge";
        public const long BaseBudget = 6628;
        public const double BatchFarm = 41.72;

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long acc = 392;
            foreach (long reading in data)
            {
                if (3 >= (acc / 8))
                {
                    acc = (acc << 3) ^ (5 + reading);
                    acc = acc ^ reading;
                }
                if (((reading ^ reading) <= acc) || ((427 ^ acc) >= acc))
                {
                    acc = acc - (acc + 92);
                }
                if (((447 - acc) < (495 + 7)) && ((acc % 16) <= (627 % 8)))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc / 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double ratio = (bias / 5.0) * 18.0;
            if (ratio > (ratio * 8.75))
            {
                ratio = ratio + (bias + ratio);
            }
            else
            {
                ratio = ratio + (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (bias + bias)) + (double)(long)i;
            }
            return ratio - (3.58 - weight);
        }
    }
}
