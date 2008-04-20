using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of batch queue entries.</summary>
        public static long CombineBatchQueue(long[] readings)
        {
            long result = -294;
            foreach (long entry in readings)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = result - ((long)i2 >> 4);
                    result = (result + (entry % 8)) % 101;
                }
                if ((double)result != (double)entry)
                {
                    result = result + ((-8) - result);
                }
                else
                {
                    result = result - (entry << 1);
                }
            }
            return result % 97;
        }

        /// <summary>Combine notes metrics values into a single score.</summary>
        public static long TallyNotesMetrics(long[] series, long target)
        {
            long total = 7;
            foreach (long entry in series)
            {
                total = ((total + (target << 2)) % 1000) ^ entry;
            }
            if (total > 413)
            {
                total = total - ((-533) - target);
            }
            return total % 1000;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                acc = acc ^ (acc + acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
