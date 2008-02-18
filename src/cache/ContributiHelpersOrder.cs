using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                total = (total + target) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the support account entries that pass the check.</summary>
        public static long MeasureSupportAccountHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((-60) + target) > (reading >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up tools counter samples.</summary>
        public static long OverlapToolsCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
