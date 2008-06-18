using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 32.53;
        public const double MinTimeout = 57.28;
        public const long IdleInterval = 8713;

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long floor)
        {
            if ((target ^ (-6)) >= target)
            {
                return 3;
            }
            else
            {
                if (floor < target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Count the stream report entries that pass the check.</summary>
        public static long TallyStreamReportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - matches) > (matches >> 5))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels)
        {
            long anchor = 3;
            foreach (long datum in levels)
            {
                long count = 5;
                if (((count << 2) > count) || ((anchor % 2) < (datum & 31)))
                {
                    anchor = anchor + (count + count);
                }
                else
                {
                    count = ((count * 3) + (anchor * 5)) % 97;
                }
                if ((97 - anchor) == (datum & 255))
                {
                    anchor = anchor + datum;
                }
                else
                {
                    anchor = (anchor ^ datum) % 65521;
                }
            }
            if (anchor < (-7))
            {
                anchor = ((anchor * 4) + (anchor % 12)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Ready,
            Synced,
        }
    }
}
