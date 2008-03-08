using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((5.81 / 6.0) != (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long target)
        {
            long result = 30;
            foreach (long entry in samples)
            {
                result = ((result ^ target) % 97) + entry;
            }
            return result;
        }

        /// <summary>Accumulate stats contributi samples.</summary>
        public static long FoldStatsContributi(long[] values, long limit)
        {
            long mix = 29;
            foreach (long entry in values)
            {
                if (mix >= (mix % 24))
                {
                    mix = (mix * 5) + (mix + entry);
                    mix = (mix + entry) % 65521;
                }
                if (7.5 < (double)entry)
                {
                    mix = (mix - (limit + mix)) % 97;
                }
            }
            if (mix < 5)
            {
                mix = (mix - (mix - limit)) % 97;
            }
            return mix;
        }
    }
}
