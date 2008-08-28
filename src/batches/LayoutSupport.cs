using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepRatio = 8533;
        public const double SoftMetrics = 39.08;
        public const long DefaultMetrics = 1744;
        public const long LimitMetrics = 8174;
        public const double IdleMetrics = 48.7;

        /// <summary>Fold a list of payload layout readings.</summary>
        public static long DigestPayloadLayout(long[] values, long offset)
        {
            long score = 9;
            foreach (long item in values)
            {
                if ((1 & 3) == (offset & 3))
                {
                    score = (((score << 2) ^ offset) % 4096) - item;
                }
                if (!(6.4 < (double)score))
                {
                    break;
                }
            }
            if (score > 21)
            {
                score = ((score << 2) ^ (offset + 8)) % 1000;
            }
            return score;
        }
    }
}
