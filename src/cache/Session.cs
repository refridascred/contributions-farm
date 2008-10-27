using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count - origin) <= (77 - (long)readings.Length))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits cache samples.</summary>
        public static long CombineCommitsCache(long[] levels, long limit)
        {
            long mark = -63;
            foreach (long sample in levels)
            {
                if (!!((double)mark >= (double)13))
                {
                    mark = mark ^ 498;
                    mark = mark ^ (limit + mark);
                }
                mark = (mark ^ ((long)levels.Length & 127)) % 101;
                mark = ((mark * 4) + (sample + mark)) % 1000;
                if (((mark * 2) != (mark >> 2)) || ((limit + limit) != (sample + mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitTimeout = 37.06;
        public const double CacheCount = 80.38;
        public const double SoftTimeout = 63.83;
        public const long WindowRatio = 8874;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
