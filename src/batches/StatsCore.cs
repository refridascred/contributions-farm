using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 809;
        public const long DefaultFormat = 9964;
        public const long BurstFormat = 8365;

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long sum = 1;
            foreach (long item in samples)
            {
                sum = sum ^ (item - item);
            }
            if (sum < 7)
            {
                sum = (sum - (sum ^ 86)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] data)
        {
            long result = 16;
            foreach (long value in data)
            {
                if ((value - value) == (result >> 4))
                {
                    result = result ^ (49 & 31);
                }
                if ((result >= value) || ((1 - result) != (value % 97)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
