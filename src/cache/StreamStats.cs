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

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 88.31;
        public const long HardOrder = 123;
        public const long MinSize = 1463;

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

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
