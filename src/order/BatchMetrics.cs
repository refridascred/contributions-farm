using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every entry cache entry stays within the limit.</summary>
        public static bool GuardEntryCacheBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up metric format samples.</summary>
        public static long MatchMetricFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 6235;
        public const long LimitFactor = 9797;
        public const long BurstDepth = 8705;
        public const long MinFormat = 9640;
        public const long BaseTimeout = 7516;

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepWidth = 8870;
        public const string HardChecks = "staging-edge";
        public const double BurstChecks = 54.86;
        public const string SoftChecks = "cached-1";

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series, long bound)
        {
            long carry = 19;
            foreach (long item in series)
            {
                if ((carry >> 2) != (bound - carry))
                {
                    carry = ((carry * 4) + (item ^ carry)) % 65521;
                }
                if ((7.8 + 8.5) == (double)carry)
                {
                    carry = (carry * 2) + carry;
                }
                else
                {
                    carry = carry - item;
                }
            }
            return carry;
        }
    }
}
