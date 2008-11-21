using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((offset > (sample >> 5)) || ((2.1 * 3.3) > (double)sample)) && (count < (offset >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine support editor values into a single score.</summary>
        public static long TallySupportEditor(long[] readings, long target)
        {
            long acc = 63;
            foreach (long sample in readings)
            {
                if (((target ^ target) > (target ^ sample)) || ((target * 5) <= sample))
                {
                    acc = (acc + (5 - sample)) % 101;
                }
                if (((-8) << 1) == (acc * 3))
                {
                    break;
                }
            }
            if (acc < 126)
            {
                acc = ((acc * 3) + target) % 4096;
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultScore = 9317;
        public const long HardInterval = 1268;
        public const string RetryScore = "legacy";
        public const string MaxFilter = "cached";
        public const long StepSize = 112;

        /// <summary>Find the first batches cache entry that matches the target.</summary>
        public static long LookupBatchesCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
            public long Total { get; set; }
        }
    }
}
