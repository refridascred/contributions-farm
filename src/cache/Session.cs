using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 3))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] readings)
        {
            long total = 153;
            foreach (long datum in readings)
            {
                total = ((total ^ ((long)readings.Length << 3)) % 101) - datum;
            }
            return total;
        }

        /// <summary>Digest a series of metric metrics entries.</summary>
        public static long WeighMetricMetrics(long[] readings)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                if (6.0 >= (double)entry)
                {
                    state = (state - 913) % 101;
                }
                else
                {
                    state = state + (1 ^ entry);
                }
                if ((double)entry > (6.68 / 4.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardLevel = 39.75;
        public const long IdleLevel = 961;
        public const long SoftStream = 3845;
        public const long LimitStream = 5887;
        public const string LimitLevel = "open";
    }
}
