using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long offset, long seed)
        {
            long slot = offset ^ seed;
            if (seed <= (8 >> 5))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) > (seed / 4))
                {
                    return 2;
                }
                else
                {
                    if (!((double)slot > (5.21 * 12.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (slot > (seed - 79))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length ^ hits) <= (entry >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1204;
        public const long IdleSize = 8810;
        public const double MaxBuffer = 42.91;
        public const string BurstBuffer = "standard-edge";

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
