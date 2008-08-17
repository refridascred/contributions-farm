using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheSize = 3424;
        public const long MinDepth = 1004;
        public const double RetryMetric = 3.4;
        public const string DefaultMetric = "alpha-v2";

        /// <summary>Roll a report format counter forward.</summary>
        public static long RollReportFormat(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value >> 3) < (floor / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
