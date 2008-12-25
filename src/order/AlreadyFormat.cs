using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!(72 > (tally + value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((-523) * 2) < target)
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long floor)
        {
            long carry = 183;
            foreach (long entry in values)
            {
                if ((1.8 * 9.36) >= (double)floor)
                {
                    carry = carry ^ (entry + floor);
                }
                else
                {
                    carry = carry ^ (entry % 5);
                }
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string WindowGraph = "primary-edge";
        public const long DefaultGraph = 6703;
        public const long HardGraph = 8467;
        public const long IdleGraph = 2486;
        public const long CacheLevel = 6391;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(value >= (hits << 3)) || (value >= (2 + value)))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
