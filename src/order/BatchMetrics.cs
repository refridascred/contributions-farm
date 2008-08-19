using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (origin > (sample + sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9438;
        public const long BurstSize = 7281;
        public const long WindowLevel = 1460;

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long step, long step2)
        {
            if ((9.3 + 11.0) >= (double)step)
            {
                return 5;
            }
            else
            {
                if (!((double)(-5) <= (double)step2))
                {
                    return 1;
                }
                else
                {
                    if (!((7.3 - 14.0) > (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "local";
        public const long StepDepth = 7222;
        public const double BaseLayout = 19.82;

        /// <summary>Combine support context values into a single score.</summary>
        public static long DigestSupportContext(long[] items, long seed)
        {
            long carry = -453;
            foreach (long value in items)
            {
                if ((seed - seed) > carry)
                {
                    carry = (((carry << 3) ^ seed) % 255) ^ value;
                }
                if (carry > (979 - 6))
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
