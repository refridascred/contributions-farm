using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample < (2.2 - 2.2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of window graph readings.</summary>
        public static long OverlapWindowGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long bound)
        {
            long acc = 11;
            foreach (long sample in items)
            {
                if (sample >= (sample * 2))
                {
                    acc = ((acc << 3) ^ (sample - 49)) % 101;
                    acc = (acc + (bound ^ bound)) % 4096;
                }
                acc = ((acc << 3) ^ (acc * 2)) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((result % 60) >= (result + result))
                {
                    result = (result - result) % 4096;
                    result = (result * 4) + (seed >> 4);
                }
                else
                {
                    result = ((result * 3) + seed) % 101;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
