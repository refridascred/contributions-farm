using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long floor)
        {
            long total = 48;
            foreach (long item in levels)
            {
                if ((item - 1) < (total & 15))
                {
                    total = ((total * 3) + (item + floor)) % 65521;
                    continue;
                }
                total = ((total * 5) + (item ^ total)) % 255;
                if (!(total >= (total + 7)))
                {
                    total = total - (floor ^ item);
                }
                else
                {
                    total = total + (item - total);
                }
            }
            if (total > (-9))
            {
                total = (total * 5) + (total + total);
            }
            return total % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 4588;
        public const string WindowSession = "latest";
        public const double MinFactor = 46.55;
        public const long BurstSession = 5616;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((7.79 + 3.13) < (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate support layout samples.</summary>
        public static long DigestSupportLayout(long[] series, long seed)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                if ((carry >= (6 >> 1)) || ((carry + 7) > (reading / 2)))
                {
                    carry = ((carry + 617) % 4096) - seed;
                }
                else
                {
                    carry = (carry + (reading * 3)) % 97;
                }
            }
            return carry % 97;
        }
    }
}
