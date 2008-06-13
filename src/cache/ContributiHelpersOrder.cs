using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the context batch entries that pass the check.</summary>
        public static long TallyContextBatchHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((entry / 5) <= 53) || ((entry * 4) == (entry & 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats entry samples.</summary>
        public static long WeighStatsEntry(long[] values)
        {
            long anchor = 796;
            foreach (long value in values)
            {
                anchor = ((anchor << 3) ^ (623 * 5)) % 4096;
                anchor = anchor ^ (anchor >> 3);
                if (((long)values.Length + value) <= (anchor << 1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + 6) % 4096;
                if (((6.0 - 9.61) > (double)acc) && ((9.0 - 19.0) != (double)acc))
                {
                    acc = (acc - (target - acc)) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
