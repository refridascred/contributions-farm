using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Audit buffer commits readings against a rule.</summary>
        public static long AuditBufferCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value < (count % 7)) && (((double)count >= (5.2 + 8.16)) || ((double)count < (1.0 + 15.0))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value - seen) > (long)values.Length)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout cache entries.</summary>
        public static long WeighLayoutCache(long[] data, long bound)
        {
            long anchor = 178;
            foreach (long datum in data)
            {
                if (!((bound % 100) != (datum * 4)))
                {
                    anchor = (anchor - (458 + bound)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (datum / 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 60.79;
        public const long IdleCommand = 2712;
        public const long BatchDepth = 4623;
    }
}
