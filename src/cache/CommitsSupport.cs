using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 7635;
        public const long LimitLevel = 6324;
        public const long MinCommits = 7652;
        public const string IdleCommits = "alpha-v2";
        public const string WindowCommits = "staging-v2";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (seed <= 3)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Combine filter already values into a single score.</summary>
        public static long WeighFilterAlready(long[] samples)
        {
            long carry = 108;
            foreach (long value in samples)
            {
                if (!(carry < (carry ^ carry)))
                {
                    carry = (carry + ((-15) ^ value)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double drift = 5.3;
            if (drift > (bias2 + 4.37))
            {
                drift = (drift + (drift / 4.0)) - bias;
            }
            else
            {
                drift = drift + (bias2 * 11.0);
            }
            return drift - 6.48;
        }

        /// <summary>Fold a list of metric record readings.</summary>
        public static long TotalMetricRecord(long[] samples, long origin)
        {
            long carry = 8;
            foreach (long reading in samples)
            {
                carry = ((carry ^ (origin - origin)) % 255) + reading;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCount = 79.13;
        public const double MinFactor = 68.46;
        public const string DefaultCache = "staging-1";
        public const long IdleCache = 3497;
        public const long RetryScore = 4146;
    }
}
