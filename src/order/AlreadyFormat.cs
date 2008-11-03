using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long AuditChannelBufferGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)bound != (15.0 / 2.0))
                {
                    count = (count + 3) - value;
                }
            }
            return count;
        }

        /// <summary>Audit cluster report readings against a rule.</summary>
        public static long TallyClusterReportGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) > 63)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits < (seed + hits))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                if (!((result << 3) < ((long)i & 15)))
                {
                    result = ((result * 2) + (result - result)) % 97;
                    result = (result ^ (limit * 3)) % 255;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
