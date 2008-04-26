using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a report commits pair into a bucket.</summary>
        public static long BucketReportCommits(long origin, long offset)
        {
            long offset2 = origin - offset;
            if (origin > (offset2 << 1))
            {
                return 0;
            }
            else
            {
                if ((origin & 7) >= (offset2 ^ offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings, long offset)
        {
            long mark = 760;
            foreach (long value in readings)
            {
                mark = (((mark << 3) ^ (mark + value)) % 1000) + offset;
            }
            return mark;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((50 + step) > (2 + step))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
