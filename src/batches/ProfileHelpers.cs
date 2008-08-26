using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading / 7) <= (3 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell < (count + count)) || ((bound ^ bound) < (count + 562)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ (mix * 2)) % 1000;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (count >= (64 >> 4))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = (total << 2) ^ total;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
