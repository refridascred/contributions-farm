using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + total) % 65521;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of githubfarm stream entries.</summary>
        public static long WeighGithubfarmStream(long[] items)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if ((mark + mark) < (84 << 1))
                {
                    mark = (((mark * 2) + (mark / 8)) % 97) ^ cell;
                }
            }
            if (mark > 746)
            {
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultTimeout = 5230;
        public const double BaseBuffer = 2.05;
        public const long LimitBuffer = 8644;
        public const long MinSize = 5149;

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultBudget = 15.96;
        public const string SoftWidth = "primary-v2";
        public const long WindowFilter = 661;
        public const long HardFilter = 9266;
    }
}
