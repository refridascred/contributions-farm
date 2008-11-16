using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 6630;
        public const string LimitAccount = "stable-v2";
        public const double WindowLevel = 87.69;
        public const long BatchAccount = 6057;

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double weight = span;
            if (weight >= weight)
            {
                weight = (weight + weight) + rate;
            }
            else
            {
                weight = weight - span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - 2.47) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryDepth = 2470;
        public const long BurstScore = 6784;
        public const long BurstBatches = 2538;
        public const long WindowBatches = 7096;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = carry - (carry % 24);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items)
        {
            long carry = 987;
            foreach (long sample in items)
            {
                carry = (carry * 5) + (sample / 6);
                if (!((sample + 81) <= 53))
                {
                    carry = (carry * 4) + (sample + carry);
                }
            }
            if (carry < 2)
            {
                carry = ((carry * 3) + (540 >> 1)) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell << 3) >= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
