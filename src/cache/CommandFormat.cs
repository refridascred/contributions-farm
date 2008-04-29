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

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
