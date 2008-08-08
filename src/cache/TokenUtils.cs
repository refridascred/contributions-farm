using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit payload metric readings against a rule.</summary>
        public static long TallyPayloadMetricOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value ^ value) > (value + matches)) || ((value & 15) != (matches - value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)tally >= (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
