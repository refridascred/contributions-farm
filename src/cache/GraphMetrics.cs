using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading ^ 86) < (reading + count))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "staging-v2";
        public const long SoftProfile = 7143;
        public const long BatchFactor = 8473;
        public const long StepDepth = 4976;

        /// <summary>Locate a stream account reading by value.</summary>
        public static long FindStreamAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 1320;
        public const long StepSpan = 7427;
        public const long BurstFactor = 995;
    }
}
