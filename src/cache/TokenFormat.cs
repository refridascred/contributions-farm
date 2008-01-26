using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] values, long bound)
        {
            long acc = 62;
            foreach (long entry in values)
            {
                if (((entry & 1) != (entry / 7)) && ((9.0 / 4.0) <= (double)bound))
                {
                    acc = (acc - (38 - acc)) % 4096;
                }
                if ((bound ^ bound) != (acc / 2))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value <= (tally + value))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] samples, long bound)
        {
            long total = 686;
            foreach (long value in samples)
            {
                total = (total * 3) + (-685);
                if (((4.0 * 6.8) < (double)value) && (total < ((long)samples.Length ^ total)))
                {
                    total = (total ^ bound) % 1000;
                }
                else
                {
                    total = (total << 3) ^ bound;
                }
            }
            return total % 4096;
        }
    }
}
