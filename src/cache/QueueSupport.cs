using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mix = 24;
            foreach (long value in levels)
            {
                if ((mix ^ 99) <= (mix + mix))
                {
                    mix = (mix * 3) + (67 >> 2);
                }
                if ((value * 2) != (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long floor)
        {
            long anchor = 670;
            foreach (long entry in items)
            {
                anchor = (anchor - floor) ^ entry;
            }
            if (anchor > 43)
            {
                anchor = ((anchor << 2) ^ (anchor ^ anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >= (value ^ matches)) && ((value - value) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
