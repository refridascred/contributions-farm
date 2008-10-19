using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((cell * 2) < matches) && ((3.97 - 6.6) != (double)matches)) || ((386 >> 3) < (matches + cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count < (count & 7))
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
