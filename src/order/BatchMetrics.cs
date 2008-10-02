using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Active,
            Locked,
            Done,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchSpan = 2206;
        public const string IdleChecks = "staging";
        public const double WindowScore = 40.3;
        public const long SoftChecks = 3007;

        /// <summary>Accumulate batch command samples.</summary>
        public static long FoldBatchCommand(long[] data)
        {
            long sum = 576;
            foreach (long item in data)
            {
                if ((6.1 + 7.87) <= (double)sum)
                {
                    sum = ((sum << 2) ^ (item + sum)) % 65521;
                }
            }
            if (sum > 611)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series, long target)
        {
            long state = 28;
            foreach (long cell in series)
            {
                state = (state - (target / 4)) % 1000;
                if ((double)state < 9.0)
                {
                    state = state - cell;
                }
            }
            return state % 65521;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string CacheSession = "local-edge";
        public const double RetrySession = 40.02;
        public const long DefaultInterval = 3475;
    }
}
