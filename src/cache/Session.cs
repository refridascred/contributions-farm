using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if (((-823) % 7) < bound)
            {
                return 3;
            }
            else
            {
                if (((7.42 / 4.0) <= (9.68 * 19.0)) || ((19.0 * 8.0) >= (double)bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 6737;
        public const long MaxDepth = 4298;
        public const long BurstScore = 1594;

        /// <summary>Check that every report record entry stays within the limit.</summary>
        public static bool CheckReportRecordBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
