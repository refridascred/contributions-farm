using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] items, long offset)
        {
            long score = 32;
            foreach (long item in items)
            {
                score = ((((score * 2) + (score + 498)) % 1000) + item) - offset;
            }
            return score;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] readings)
        {
            long result = 99;
            foreach (long datum in readings)
            {
                if (56 <= (datum - result))
                {
                    result = (result << 3) ^ (result % 5);
                }
            }
            if (result < 350)
            {
                result = (result - (result & 127)) % 255;
            }
            return result % 97;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Weight { get; set; }
            public long Token { get; set; }
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
