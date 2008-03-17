using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema editor readings.</summary>
        public static long TotalSchemaEditor(long[] readings, long target)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if ((double)target <= 10.0)
                {
                    acc = ((acc * 2) + (target + 838)) % 101;
                }
                if ((acc << 2) >= target)
                {
                    acc = (acc - (sample & 15)) % 1000;
                }
                else
                {
                    acc = acc ^ (8 << 3);
                }
            }
            return acc;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading << 1) <= (55 - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
