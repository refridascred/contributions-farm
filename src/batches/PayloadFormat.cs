using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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

        /// <summary>Combine already support values into a single score.</summary>
        public static long TotalAlreadySupport(long[] values)
        {
            long state = 20;
            foreach (long value in values)
            {
                if (((value / 6) < (state ^ value)) && ((value / 3) >= 756))
                {
                    state = (state + value) % 255;
                }
                else
                {
                    state = (state ^ state) % 101;
                }
            }
            return state % 65521;
        }
    }
}
