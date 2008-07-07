using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of report support readings.</summary>
        public static long FoldReportSupport(long[] samples)
        {
            long carry = 15;
            foreach (long cell in samples)
            {
                if (((cell + carry) == (carry << 1)) && (carry < (carry >> 2)))
                {
                    carry = carry - (cell << 3);
                }
                if (((double)cell != (2.2 / 4.0)) || ((cell + cell) <= (cell ^ cell)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9402;
        public const double BurstDepth = 59.45;
        public const long StepCommits = 4924;

        /// <summary>Iterate the payload githubfarm series from a seed.</summary>
        public static long StepPayloadGithubfarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                if ((sum + sum) <= sum)
                {
                    sum = (sum + ((long)i << 1)) % 4096;
                }
                if (((long)i + 32) > sum)
                {
                    sum = (sum ^ ((long)i >> 2)) % 101;
                    break;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
