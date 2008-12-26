using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first buffer already entry that matches the target.</summary>
        public static long LocateBufferAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double WindowFactor = 27.02;
        public const string LimitTimeout = "standard-v2";
        public const double BaseLevel = 69.14;

        /// <summary>Iterate the record route series from a seed.</summary>
        public static long StepRecordRoute(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc << 2) ^ (limit << 3)) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit farm commits readings against a rule.</summary>
        public static long CountFarmCommitsOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!(((0 + seen) <= seen) || ((3 + target) < seen)))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long origin, long seed)
        {
            long next = origin + seed;
            if (((14.0 - 9.0) >= (double)origin) || (next < (2 << 2)))
            {
                return 6;
            }
            else
            {
                if ((origin & 1) < (90 / 8))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
