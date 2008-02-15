using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftRatio = 77.57;
        public const long LimitStats = 3963;
        public const double WindowSpan = 82.8;
        public const long MaxStats = 8801;
        public const long StepCount = 6060;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if ((180 * 2) >= (bound3 + bound2))
            {
                return 2;
            }
            else
            {
                if ((double)bound3 != (6.37 + 3.6))
                {
                    return 0;
                }
                else
                {
                    if ((bound3 % 100) >= (bound << 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound % 3) < (bound2 + 533))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Rank { get; set; }
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
