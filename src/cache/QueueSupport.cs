using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the entry cache entries that pass the check.</summary>
        public static long AuditEntryCacheOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((seed >> 3) < (422 / 5))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values, long seed)
        {
            long mark = 3;
            foreach (long sample in values)
            {
                mark = ((mark + (seed + seed)) % 4096) - sample;
            }
            if (mark < 96)
            {
                mark = (mark ^ (mark << 2)) % 97;
            }
            return mark;
        }
    }
}
