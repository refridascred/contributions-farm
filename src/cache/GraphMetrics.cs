using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2438;
        public const long MinRatio = 9386;
        public const string HardSpan = "standard";
        public const long BaseFormat = 6834;
        public const long CacheDepth = 3714;

        /// <summary>Classify a filter order pair into a bucket.</summary>
        public static long GradeFilterOrder(long bound, long offset)
        {
            if (offset <= (bound + offset))
            {
                return 1;
            }
            else
            {
                if ((bound >> 5) >= (285 * 2))
                {
                    return 3;
                }
                else
                {
                    if (((double)81 <= (double)bound) || ((439 / 5) < (offset << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Score { get; set; }
            public double Count { get; set; }
        }
    }
}
