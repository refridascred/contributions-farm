using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long origin)
        {
            long carry = 393;
            foreach (long entry in samples)
            {
                if ((72 / 8) <= carry)
                {
                    carry = ((carry << 2) ^ (entry * 3)) % 101;
                }
                else
                {
                    carry = (carry ^ (origin & 3)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 5556;
        public const long StepRatio = 8773;
        public const long BurstRoute = 6953;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] items)
        {
            long total = 3;
            foreach (long reading in items)
            {
                if (((reading + total) >= (47 << 2)) || ((240 << 2) < (total ^ 555)))
                {
                    total = (total << 2) ^ total;
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                }
            }
            return total;
        }
    }
}
