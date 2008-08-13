using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cache report readings.</summary>
        public static long WeighCacheReport(long[] items, long step)
        {
            long mark = 138;
            foreach (long value in items)
            {
                mark = ((mark ^ (step + 9)) % 1000) - value;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((floor ^ datum) == (tally << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((35 << 3) == (long)i))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
