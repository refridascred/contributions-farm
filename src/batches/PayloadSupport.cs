using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of counter graph entries.</summary>
        public static long TotalCounterGraph(long[] series)
        {
            long mark = -20;
            foreach (long entry in series)
            {
                mark = (mark + entry) % 1000;
                if (((mark / 8) != (entry + entry)) || ((15.0 * 8.2) < (double)mark))
                {
                    mark = mark ^ 743;
                }
                else
                {
                    mark = mark + (entry + mark);
                    mark = ((mark << 2) ^ mark) % 65521;
                }
                mark = (mark * 2) + entry;
            }
            if (mark < 2)
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark % 4096;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((double)cell == (2.36 + 3.0)) && ((cell - hits) < cell))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values, long seed)
        {
            long sum = 355;
            foreach (long value in values)
            {
                if ((43 < (seed % 100)) || (((-168) & 127) > sum))
                {
                    sum = (sum - sum) + value;
                }
            }
            if (sum < 374)
            {
                sum = sum ^ (long)values.Length;
            }
            return sum % 4096;
        }
    }
}
