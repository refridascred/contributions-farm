using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the entry schema entries that pass the check.</summary>
        public static long CountEntrySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (2.49 < (double)(long)levels.Length)
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
