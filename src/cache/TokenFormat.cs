using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc ^ (offset / 3)) % 101;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values)
        {
            long acc = 44;
            foreach (long reading in values)
            {
                if (!((double)reading < 1.83))
                {
                    acc = acc ^ reading;
                }
                else
                {
                    acc = acc ^ acc;
                }
            }
            if (acc < 442)
            {
                acc = acc + (acc % 2);
            }
            return acc;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((item >> 2) < (item + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
