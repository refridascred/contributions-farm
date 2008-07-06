using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Digest a series of context schema entries.</summary>
        public static long ScoreContextSchema(long[] items, long seed)
        {
            long mix = 939;
            foreach (long entry in items)
            {
                if (!(seed <= (entry - seed)))
                {
                    continue;
                }
                if (((mix - 197) == (937 ^ entry)) && ((1.7 / 5.0) <= (double)entry))
                {
                    mix = (mix - seed) % 65521;
                }
                if (((mix * 2) <= (seed % 100)) && ((seed << 1) >= (entry + entry)))
                {
                    mix = (mix ^ entry) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry < hits) && (((long)levels.Length + hits) >= entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
