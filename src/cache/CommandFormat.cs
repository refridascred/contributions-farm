using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total + (19 + 993)) % 4096) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long DeriveCacheAlready(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry / 5))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Combine already stats values into a single score.</summary>
        public static long ScoreAlreadyStats(long[] data, long origin)
        {
            long anchor = 231;
            foreach (long entry in data)
            {
                if ((19.0 / 5.0) != (double)(long)data.Length)
                {
                    anchor = (anchor - (origin + anchor)) ^ entry;
                }
            }
            return anchor;
        }
    }
}
