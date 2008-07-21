using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many schema command samples are out of range.</summary>
        public static long CountSchemaCommandHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((15 & 255) != (hits - datum))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long mix = 12;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + (long)items.Length) - reading;
                mix = ((mix << 2) ^ (target ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Validate notes buffer readings against a bound.</summary>
        public static bool VerifyNotesBufferBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
