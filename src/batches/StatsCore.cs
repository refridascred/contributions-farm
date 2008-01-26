using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultBudget = 79.05;
        public const long StepSpan = 8245;
        public const long IdleTools = 4141;

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultScore = "standard";
        public const long WindowLevel = 4069;
        public const long BatchRatio = 9060;
        public const string CacheWindow = "staging-1";
        public const double MinDepth = 13.09;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Locked,
            Paused,
            Queued,
            New,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] values, long target)
        {
            long carry = 5;
            foreach (long entry in values)
            {
                carry = (carry << 3) ^ entry;
                carry = (carry + (target * 5)) % 255;
                carry = (carry << 3) ^ (target % 60);
            }
            if (carry < (-56))
            {
                carry = carry - (carry / 3);
            }
            return carry;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
