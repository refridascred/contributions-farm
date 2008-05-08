using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long offset)
        {
            if (offset <= step)
            {
                return 4;
            }
            else
            {
                if (((step / 4) != (step ^ step)) || (6 > (offset << 2)))
                {
                    return 0;
                }
                else
                {
                    if (8.2 >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftInterval = 6564;
        public const long IdleCommits = 8552;
        public const long MaxCommits = 3376;
        public const double BatchCommits = 91.85;
        public const long BatchTimeout = 161;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (seen <= ((-3) >> 2))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a token session sample.</summary>
        public static long SeekTokenSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
