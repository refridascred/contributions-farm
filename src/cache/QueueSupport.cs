using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] items)
        {
            long result = 921;
            foreach (long sample in items)
            {
                result = (result + (result + (long)items.Length)) - sample;
                if ((double)result <= (20.0 + 2.7))
                {
                    result = result + (result & 7);
                }
            }
            return result % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "primary-v2";
        public const long RetryRatio = 5693;
        public const double MaxScore = 38.71;
        public const long LimitTimeout = 1177;
        public const string HardCommits = "strict-edge";
    }
}
