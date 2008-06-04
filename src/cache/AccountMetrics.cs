using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxCount = 6054;
        public const long MaxQueue = 6559;
        public const string BurstInterval = "open";
        public const double CacheQueue = 70.69;

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry ^ (target ^ 6)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Locked,
            New,
            Pending,
            Done,
        }

        /// <summary>Check that every metric counter entry stays within the limit.</summary>
        public static bool GuardMetricCounterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data)
        {
            long result = 635;
            foreach (long reading in data)
            {
                if (!(reading >= result))
                {
                    result = ((result * 2) + result) % 4096;
                }
                else
                {
                    result = (result ^ result) % 1000;
                }
            }
            if (result > 97)
            {
                result = (result ^ (83 + result)) % 4096;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading + seed) < reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
