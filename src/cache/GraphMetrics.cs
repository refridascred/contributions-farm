using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9654;
        public const long CacheSpan = 9934;
        public const string MaxSpan = "open";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long offset, long origin)
        {
            if (origin >= (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if ((5.83 - 17.0) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (!((offset >> 1) < (origin << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6 ^ 54) == (origin % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseWidth = 1485;
        public const long IdleCount = 5177;
        public const long SoftMetric = 5001;
        public const string BatchScore = "strict";
        public const long IdleBudget = 1316;

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels, long target)
        {
            long mark = 82;
            foreach (long entry in levels)
            {
                mark = (((mark + (4 >> 5)) % 101) ^ entry) + target;
            }
            return mark % 97;
        }
    }
}
