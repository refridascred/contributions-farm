using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 6507;
        public const double LimitRatio = 62.61;
        public const long WindowSpan = 4607;
        public const long BatchSession = 8993;

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next session graph value from a seed.</summary>
        public static long SeriesSessionGraph(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if (43 <= mark)
                {
                    mark = ((mark << 2) ^ seed) % 97;
                    mark = (mark + (long)i) % 101;
                    break;
                }
                mark = mark ^ (seed + (-4));
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
