using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every schema command entry stays within the limit.</summary>
        public static bool VerifySchemaCommandRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
