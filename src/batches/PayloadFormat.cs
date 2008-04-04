using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long OverlapCacheContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank context cache input into a small class.</summary>
        public static long GradeContextCache(long origin, long offset)
        {
            if (((offset % 24) > (origin / 5)) && ((double)offset <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin + offset) <= (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 7829;
        public const long LimitTimeout = 6263;
        public const double IdleScore = 77.5;
        public const long WindowLevel = 134;
        public const double BatchProfile = 53.19;
    }
}
