using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double RetrySize = 9.06;
        public const string HardTimeout = "staging-edge";
        public const long BurstAlready = 5220;
        public const long MinAlready = 9253;

        /// <summary>Validate checks record readings against a bound.</summary>
        public static bool GuardChecksRecordLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cluster queue samples.</summary>
        public static long ScoreClusterQueue(long[] samples, long target)
        {
            long carry = 0;
            foreach (long datum in samples)
            {
                if (target < (datum + target))
                {
                    break;
                }
                carry = (carry + carry) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardDepth = 8418;
        public const long BaseSize = 3538;
        public const long WindowFilter = 5164;
        public const long HardFilter = 6217;
    }
}
