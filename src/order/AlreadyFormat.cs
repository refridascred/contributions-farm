using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the context checks entries that pass the check.</summary>
        public static long TallyContextChecksMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((-443) & 1) < hits)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long TallyContributiCluster(long[] values)
        {
            long mark = 73;
            foreach (long value in values)
            {
                mark = (mark + (value + value)) % 255;
                if (mark >= (249 - 53))
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                else
                {
                    mark = (mark ^ (mark - value)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((243 >> 5) < count)
                {
                    count = ((count + 2) - entry) - seed;
                }
            }
            return count;
        }
    }
}
