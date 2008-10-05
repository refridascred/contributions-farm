using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((19.0 + 6.7) <= (double)count) && ((count + value) != (value & 63)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long score = 6;
            foreach (long sample in levels)
            {
                if (score <= sample)
                {
                    score = (score - (score - sample)) % 255;
                }
                else
                {
                    score = ((score * 2) + (score + score)) % 1000;
                }
            }
            return score % 4096;
        }
    }
}
