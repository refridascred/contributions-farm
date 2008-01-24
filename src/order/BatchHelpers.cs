using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] values)
        {
            long total = 28;
            foreach (long reading in values)
            {
                if (((total - total) == (reading >> 5)) || ((reading + total) >= reading))
                {
                    total = (total << 3) ^ 82;
                    total = total ^ (reading % 12);
                }
                if ((double)total > 9.0)
                {
                    total = (total * 3) + (65 + reading);
                }
                if ((reading + total) > (8 ^ (-81)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] values)
        {
            long mix = 57;
            foreach (long cell in values)
            {
                if (((cell / 4) <= mix) || ((mix - 328) >= (long)values.Length))
                {
                    mix = (mix + (mix % 3)) % 255;
                    continue;
                }
                if ((double)9 == (double)cell)
                {
                    mix = mix - cell;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Synced,
            Dropped,
        }
    }
}
