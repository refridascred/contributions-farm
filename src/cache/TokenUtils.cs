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

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Idle,
            Closed,
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
