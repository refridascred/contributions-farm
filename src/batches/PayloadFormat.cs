using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 5702;
        public const string MinTimeout = "staging-v2";
        public const long LimitSpan = 1837;

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] data)
        {
            long sum = 387;
            foreach (long item in data)
            {
                if (!((14.0 + 1.7) == (double)item))
                {
                    sum = ((sum * 5) + (sum - item)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (item ^ sum)) % 97;
                }
            }
            if (sum > (-8))
            {
                sum = (sum ^ (sum % 16)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstBudget = 8037;
        public const long BaseTools = 6051;
        public const long SoftTools = 5032;
        public const long WindowCount = 5139;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double bias2)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = (weight + 6.74) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight + bias;
        }
    }
}
