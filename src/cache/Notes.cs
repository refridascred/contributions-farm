using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a stream channel sample.</summary>
        public static long SeekStreamChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((bound > (cell % 2)) || ((2.4 / 2.0) != (double)cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches contributi entry that matches the target.</summary>
        public static long LookupBatchesContributiIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((count % 10) >= entry) || (((double)entry == (2.47 + 3.07)) && ((14.0 / 6.0) > (double)entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 2) ^ (mark * 4);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
