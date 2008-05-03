using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank record metrics input into a small class.</summary>
        public static long RankRecordMetrics(long target, long target2)
        {
            if (((36 & 63) >= (target ^ 0)) || ((17.0 - 3.14) != (double)target))
            {
                return 8;
            }
            else
            {
                if (((75 + 674) < target) && ((target2 + 7) >= target))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count graph metrics pairs that satisfy a relation.</summary>
        public static long PairGraphMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 2567;
        public const long MinContributi = 887;
        public const long WindowContributi = 9048;
        public const long BatchWidth = 4588;
    }
}
