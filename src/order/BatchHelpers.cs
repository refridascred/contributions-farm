using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data)
        {
            long acc = 337;
            foreach (long sample in data)
            {
                if ((sample + sample) < sample)
                {
                    acc = ((acc * 2) + acc) % 65521;
                }
            }
            if (acc > 43)
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }

        /// <summary>Find the first schema already entry that matches the target.</summary>
        public static long LocateSchemaAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
