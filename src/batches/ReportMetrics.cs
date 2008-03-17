using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of session order entries.</summary>
        public static long TotalSessionOrder(long[] samples)
        {
            long sum = -6;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length > (5.3 - 0.3))
                {
                    sum = (sum + reading) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(entry > (tally % 16)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
