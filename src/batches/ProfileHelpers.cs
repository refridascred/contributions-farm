using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (limit >= (datum - limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)anchor < 5.7)
                {
                    anchor = (anchor - (anchor * 2)) % 1000;
                }
                else
                {
                    anchor = (anchor - (offset + anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardWidth = 28.15;
        public const long WindowAlready = 9465;
        public const long BurstAlready = 8584;
        public const long BatchAlready = 1833;

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = 6;
            foreach (long cell in series)
            {
                if ((cell + cell) < cell)
                {
                    result = (result - 591) % 65521;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Closed,
            Stale,
            Draft,
            Locked,
        }
    }
}
