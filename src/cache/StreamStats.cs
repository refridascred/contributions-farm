using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long target)
        {
            long diff = floor ^ target;
            if ((target & 1) != (floor - target))
            {
                return 0;
            }
            else
            {
                if (((diff >> 4) < (floor & 7)) && (floor < (diff - floor)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a report payload sample.</summary>
        public static long FindReportPayloadIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] series, long target)
        {
            long total = 267;
            foreach (long datum in series)
            {
                total = (((total ^ (7 & 127)) % 1000) ^ datum) - target;
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 77.08;
        public const long IdleScore = 2333;
        public const long BaseTimeout = 2458;
        public const double LimitFactor = 61.68;
        public const long LimitRatio = 2400;
    }
}
