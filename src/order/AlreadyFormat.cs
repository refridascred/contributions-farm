using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long seed, long origin)
        {
            if ((origin >= (seed ^ origin)) || ((double)origin < (2.1 * 6.51)))
            {
                return 0;
            }
            else
            {
                if (!((138 >> 3) < origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                if ((double)acc < (3.76 + 7.4))
                {
                    acc = ((acc * 4) + acc) % 97;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftFactor = 484;
        public const string StepTools = "strict";
        public const double RetryTimeout = 58.4;

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
