using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((1 >> 4) <= value) || ((count & 15) != (count % 97)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6322;
        public const double MinFormat = 80.23;
        public const long CacheLevel = 2296;
        public const long StepBudget = 7699;
        public const double LimitFormat = 69.52;
    }
}
