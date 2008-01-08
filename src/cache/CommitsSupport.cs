using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Locked,
            Pending,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            Dropped,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftDepth = 2569;
        public const long RetrySupport = 2249;
        public const double BaseLevel = 62.01;
        public const long CacheSupport = 3600;

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] values)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                carry = (((carry << 2) ^ (85 & 15)) % 65521) ^ cell;
            }
            if (carry < 4)
            {
                carry = carry ^ 127;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] data, long limit)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if (mark > (mark & 3))
                {
                    mark = (mark + (limit - mark)) % 255;
                    continue;
                }
                else
                {
                    mark = (mark << 3) ^ (long)data.Length;
                    mark = (mark ^ (item - limit)) % 65521;
                }
                if (((330 + 98) <= (item - mark)) || ((item >> 5) >= mark))
                {
                    mark = mark - (mark >> 4);
                }
            }
            return mark % 97;
        }
    }
}
