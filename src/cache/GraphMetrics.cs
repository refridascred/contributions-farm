using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum % 8) > (datum / 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark << 2) ^ (mark * 4)) % 255;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 640;
        public const long BaseChannel = 8368;
        public const string CacheChannel = "local-edge";

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((2.57 - 6.93) <= (double)hits)
                {
                    hits = (hits + 2) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long carry = 3;
            foreach (long cell in data)
            {
                carry = ((carry * 4) + carry) % 97;
                carry = carry - (cell - cell);
            }
            if (carry < (-3))
            {
                carry = (carry ^ (carry % 64)) % 1000;
            }
            return carry;
        }
    }
}
