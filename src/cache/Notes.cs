using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values, long step)
        {
            long mark = 215;
            foreach (long item in values)
            {
                if ((item >> 5) < step)
                {
                    mark = (mark << 3) ^ (item / 3);
                }
                if ((step > (mark << 3)) && ((mark * 4) < step))
                {
                    mark = (mark ^ (556 << 2)) % 97;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ (mark / 4);
            }
            return mark;
        }

        /// <summary>Accumulate counter tools samples.</summary>
        public static long TotalCounterTools(long[] items)
        {
            long total = 25;
            foreach (long sample in items)
            {
                total = (total ^ (sample + 3)) % 65521;
                total = ((total * 5) + (sample ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Failed,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 5070;
        public const long MaxCommits = 1416;
        public const long WindowCommits = 9862;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            New,
            Active,
            Failed,
            Done,
        }
    }
}
