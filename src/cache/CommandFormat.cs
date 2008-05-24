using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] values)
        {
            long sum = 24;
            foreach (long item in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum - ((long)i & 3)) % 1000;
                    sum = ((sum * 2) + (sum + (long)i)) % 65521;
                }
                if ((0.83 - 8.0) == (double)item)
                {
                    sum = (sum - (item + sum)) % 65521;
                }
                else
                {
                    sum = (sum << 3) ^ (sum + item);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] items)
        {
            long anchor = -2;
            foreach (long datum in items)
            {
                if ((1 - anchor) > anchor)
                {
                    anchor = anchor - (anchor + anchor);
                }
                else
                {
                    anchor = anchor + (datum & 127);
                }
            }
            if (anchor < 3)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheRatio = 74.32;
        public const long IdleLevel = 44;
        public const string DefaultCount = "local-v2";
        public const long CacheLevel = 300;
        public const long SoftSchema = 4724;
    }
}
