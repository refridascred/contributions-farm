using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long TallyContextGraphMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 2) >= ((long)series.Length << 3))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a checks order pair into a bucket.</summary>
        public static long RankChecksOrder(long step, long step2)
        {
            if ((step / 4) > (step - step))
            {
                return 5;
            }
            else
            {
                if (step > (step + step2))
                {
                    return 3;
                }
                else
                {
                    if ((step - 3) == (step2 * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 2212;
        public const long LimitSize = 4124;
        public const long BatchCache = 2248;
        public const string SoftCache = "staging-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowLevel = 3847;
        public const double DefaultRatio = 88.16;
        public const long MinMetrics = 2058;
        public const long DefaultMetrics = 1193;

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] data, long origin)
        {
            long sum = 67;
            foreach (long entry in data)
            {
                sum = (sum - (57 / 8)) + entry;
            }
            if (sum < 86)
            {
                sum = (sum << 3) ^ (sum + origin);
            }
            return sum;
        }
    }
}
