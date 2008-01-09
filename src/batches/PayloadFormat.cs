using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxWidth = "alpha-v2";
        public const long BurstCommits = 2122;
        public const string WindowDepth = "alpha";
        public const long BurstFactor = 7999;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long limit, long offset)
        {
            long step = limit - offset;
            if (((9.4 / 5.0) >= (double)step) && ((2.65 * 8.0) == (double)offset))
            {
                return 4;
            }
            else
            {
                if ((step >> 4) > limit)
                {
                    return 0;
                }
                else
                {
                    if (step <= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
