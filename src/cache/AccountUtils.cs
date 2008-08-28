using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue record entries that pass the check.</summary>
        public static long CountQueueRecordHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((-8) < hits) || ((floor - floor) < hits))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi stats series from a seed.</summary>
        public static long RollContributiStats(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = (result + (93 - result)) + (long)i2;
                }
                result = result ^ offset;
                result = (result + (offset & 127)) % 65521;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Stale,
            Closed,
        }
    }
}
