using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] data)
        {
            long state = 68;
            foreach (long entry in data)
            {
                if ((5.7 / 5.0) < (double)entry)
                {
                    state = ((state * 4) + (long)data.Length) % 101;
                }
            }
            return state;
        }

        /// <summary>Audit batch token readings against a rule.</summary>
        public static long AuditBatchTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell >> 3) >= hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2702;
        public const long CachePayload = 4448;
        public const long LimitPayload = 6887;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 84.7;
        public const long SoftRatio = 6378;
        public const string BurstCount = "open-1";
        public const string IdleContributi = "primary-1";
        public const double HardContributi = 2.91;

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
