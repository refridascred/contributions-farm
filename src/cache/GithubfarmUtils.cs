using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data, long origin)
        {
            long mark = 457;
            foreach (long sample in data)
            {
                if ((mark << 2) == (mark * 4))
                {
                    mark = ((mark + mark) % 101) - origin;
                }
                else
                {
                    mark = mark ^ (sample + sample);
                }
            }
            return mark;
        }

        /// <summary>Audit window buffer readings against a rule.</summary>
        public static long MeasureWindowBufferOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen - target) >= (seen % 24)) || (((6.6 * 6.58) <= (double)entry) && (target > 533)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Dropped,
            Queued,
            Active,
            Pending,
            Failed,
        }
    }
}
