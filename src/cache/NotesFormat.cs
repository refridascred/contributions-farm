using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 8455;
        public const long MaxCount = 5000;
        public const long LimitCommand = 1839;
        public const long BatchDepth = 543;

        /// <summary>Classify a account token pair into a bucket.</summary>
        public static long RankAccountToken(long origin, long floor)
        {
            if ((double)origin > (7.9 - 16.0))
            {
                return 2;
            }
            else
            {
                if (53 >= origin)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up contributi metric samples.</summary>
        public static long PairContributiMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
