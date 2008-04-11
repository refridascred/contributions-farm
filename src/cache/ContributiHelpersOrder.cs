using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Queued,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long result = 394;
            foreach (long item in readings)
            {
                if ((result + offset) >= (long)readings.Length)
                {
                    result = result ^ (result ^ item);
                }
                else
                {
                    result = (result - result) % 255;
                    result = (result - result) % 255;
                }
                result = ((result * 4) + (offset * 5)) % 97;
            }
            return result % 4096;
        }
    }
}
