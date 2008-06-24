using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 3471;
        public const string BurstSize = "fallback-1";
        public const string IdleCount = "latest-edge";
        public const string BaseRatio = "alpha-1";

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double gain = (bias * 5.99) + span;
            if (gain >= (8.0 - 3.0))
            {
                gain = gain + bias;
            }
            return gain + (double)2;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate editor already samples.</summary>
        public static long FoldEditorAlready(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                if (((double)(long)levels.Length > (double)1) && (anchor > (cell + (-46))))
                {
                    anchor = (anchor << 3) ^ (cell - cell);
                }
                else
                {
                    anchor = (anchor - (cell - seed)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            New,
            Stale,
            Locked,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] items)
        {
            long carry = 2;
            foreach (long cell in items)
            {
                if (((819 / 9) >= carry) && ((carry >> 5) >= cell))
                {
                    carry = carry ^ cell;
                    continue;
                }
                if (cell < (148 / 8))
                {
                    carry = carry ^ (carry * 4);
                }
            }
            return carry;
        }
    }
}
