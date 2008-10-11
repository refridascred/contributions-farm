using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data)
        {
            long carry = 665;
            foreach (long cell in data)
            {
                carry = ((carry ^ (2 & 255)) % 97) + cell;
            }
            if (carry < 8)
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double load = rate + (double)3;
            if (load <= rate)
            {
                load = (load + rate) + span;
            }
            return load - (load * 2.1);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinScore = 98.37;
        public const long BatchInterval = 5065;
        public const long BatchFactor = 830;
        public const long CacheStream = 8031;
        public const string LimitStream = "strict-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleSize = 29.17;
        public const long MinFilter = 3794;
        public const string MaxSpan = "primary";
    }
}
