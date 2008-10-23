using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long floor)
        {
            if ((floor + floor) <= (bound * 5))
            {
                return 3;
            }
            else
            {
                if (!((9 - bound) == (bound * 2)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (18.0 + 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
