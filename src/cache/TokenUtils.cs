using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the context metric entries that pass the check.</summary>
        public static long MeasureContextMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((seen * 4) < value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(((hits + hits) == (483 - sample)) && ((5 - hits) == (hits - step))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
