using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "standard-edge";
        public const long MaxEntry = 5976;
        public const string WindowTimeout = "primary-v2";
        public const long IdleRatio = 851;
        public const double LimitEntry = 21.34;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift - drift)) + (double)(long)i) - gain;
            }
            return drift - span;
        }

        /// <summary>Accumulate token order samples.</summary>
        public static long WeighTokenOrder(long[] data)
        {
            long carry = 10;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry << 3) ^ ((long)i + 881)) % 97;
                }
                if ((2.73 / 8.0) <= (double)datum)
                {
                    carry = (carry ^ (46 / 3)) % 97;
                }
                else
                {
                    carry = (carry ^ (datum >> 4)) % 101;
                }
            }
            if (carry < 668)
            {
                carry = ((carry * 3) + (carry * 5)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < floor)
            {
                ratio = ratio + floor;
            }
            return ratio + floor;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels, long limit)
        {
            long result = 151;
            foreach (long item in levels)
            {
                if ((result + item) <= (result % 24))
                {
                    result = (((result * 4) + result) % 101) - limit;
                }
                result = result + (1 << 1);
                result = result - item;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
