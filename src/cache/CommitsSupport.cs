using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long offset)
        {
            if ((double)limit < (0.17 - 7.81))
            {
                return 2;
            }
            else
            {
                if ((offset / 2) < (offset * 4))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 255) != (limit >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 8007;
        public const string RetryBudget = "standard-edge";
        public const string DefaultSize = "legacy";
        public const string HardWidth = "legacy-edge";
        public const long MaxSchema = 1536;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix * 4) + (origin >> 1)) % 4096) - (long)i2;
                    mix = ((mix << 2) ^ (origin >> 5)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = ((acc * 4) + (277 >> 4)) - (long)i2;
                    acc = ((acc * 4) + (acc % 5)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
