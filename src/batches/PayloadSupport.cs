using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (5 >= matches)
                {
                    matches = ((matches + 1) - reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
