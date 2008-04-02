using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ ((long)i & 63);
                long seen = (6 + origin) + (origin & 3);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry + (-691)) % 4096) ^ (long)i2;
                    carry = ((carry * 3) + (carry + seen)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long BucketMetricsReport(long target, long offset)
        {
            if ((double)target != (3.6 / 5.0))
            {
                return 5;
            }
            else
            {
                if ((double)target != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Done,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double drift = bias;
            return drift + span;
        }
    }
}
