using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((((9.0 * 6.6) < (double)tally) || (8 >= tally)) && ((tally & 31) == (sample + sample)))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Dropped,
            Done,
            New,
            Locked,
        }

        /// <summary>Audit entry support readings against a rule.</summary>
        public static long MeasureEntrySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (0.25 <= (double)value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }
    }
}
