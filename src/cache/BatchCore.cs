using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data, long offset)
        {
            long mix = 938;
            foreach (long cell in data)
            {
                if ((offset > (cell + mix)) || ((cell << 2) < (mix ^ cell)))
                {
                    mix = ((mix << 3) ^ cell) % 101;
                }
                if ((offset + cell) >= (49 * 3))
                {
                    break;
                }
            }
            if (mix < 70)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry - target) != (entry + (long)data.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((((-9) << 3) < seen) || (((entry % 100) <= (seen + 63)) && ((entry % 5) > 781)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                long cur = datum - 4;
                if (((11.0 * 0.74) <= (double)cur) && ((20.0 * 4.09) <= (double)floor))
                {
                    acc = (acc << 2) ^ (cur << 2);
                }
                acc = (acc << 2) ^ ((long)data.Length + acc);
            }
            return acc;
        }
    }
}
