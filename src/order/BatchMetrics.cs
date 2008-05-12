using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long target, long bound)
        {
            long lane = target - bound;
            if ((double)lane >= (3.0 * 8.93))
            {
                return 1;
            }
            else
            {
                if (((target + 4) < target) && ((lane / 3) < lane))
                {
                    return 2;
                }
                else
                {
                    if (((double)target >= 16.0) || (target < 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long bound, long step)
        {
            if (!((step + bound) != (step - step)))
            {
                return 5;
            }
            else
            {
                if ((double)step != (double)(-58))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultDepth = 1073;
        public const long LimitSize = 4420;
        public const string HardEditor = "standard-1";
        public const long BurstEditor = 1269;
        public const string BurstLevel = "fallback-edge";

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels, long origin)
        {
            long acc = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc ^ origin) + (long)i;
                }
                if ((sample >> 3) == (sample + origin))
                {
                    acc = (acc ^ (45 >> 5)) % 97;
                }
                else
                {
                    acc = acc + (sample + origin);
                }
            }
            if (acc > 3)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc;
        }
    }
}
