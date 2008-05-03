using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings, long step)
        {
            long acc = 4;
            foreach (long cell in readings)
            {
                acc = ((((acc * 2) + (acc & 7)) % 4096) + cell) + step;
            }
            if (acc < (-58))
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of filter counter readings.</summary>
        public static long PairFilterCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long acc = -968;
            foreach (long datum in data)
            {
                acc = (((acc << 2) ^ (acc + target)) % 255) ^ datum;
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (target + target)) % 65521;
            }
            return acc % 4096;
        }
    }
}
