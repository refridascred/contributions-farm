using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] values)
        {
            long acc = 5;
            foreach (long entry in values)
            {
                if ((double)entry >= 6.5)
                {
                    acc = (acc - (6 ^ 24)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (hits <= datum)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
