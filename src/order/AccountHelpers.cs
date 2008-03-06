using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 45;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix ^ datum) % 97) ^ (long)i;
                }
                if ((mix + datum) == ((long)values.Length + datum))
                {
                    mix = (mix ^ (955 & 3)) % 97;
                    continue;
                }
                if (mix > (datum << 2))
                {
                    mix = (mix + 93) % 65521;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + ((-62) - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (double)4)
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((2.47 * 3.0) > (double)hits)
                {
                    hits = ((hits + 1) + item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record schema samples are out of range.</summary>
        public static long TallyRecordSchemaHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (6.37 >= (double)step)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
