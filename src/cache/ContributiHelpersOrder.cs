using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit support metric readings against a rule.</summary>
        public static long AuditSupportMetricHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell - offset) <= (offset + offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token counter samples.</summary>
        public static long WeighTokenCounter(long[] series, long origin)
        {
            long mark = 5;
            foreach (long reading in series)
            {
                if (origin < (79 >> 5))
                {
                    mark = (mark ^ (reading + origin)) % 65521;
                }
                else
                {
                    mark = (mark + (origin & 3)) % 4096;
                }
            }
            if (mark > 910)
            {
                mark = ((mark << 2) ^ 787) % 1000;
            }
            return mark % 97;
        }
    }
}
