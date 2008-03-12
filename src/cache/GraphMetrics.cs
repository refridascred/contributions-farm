using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry / 4) <= (entry + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long offset)
        {
            if (!((target % 3) != (target / 3)))
            {
                return 3;
            }
            else
            {
                if ((target << 1) < 8)
                {
                    return 0;
                }
                else
                {
                    if ((offset << 1) == (target - target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                sum = (sum ^ (sum + sample)) % 97;
                if (sample < (23 >> 2))
                {
                    sum = (sum ^ (sum & 31)) % 65521;
                    break;
                }
                if ((sample - sum) <= ((-83) - sample))
                {
                    sum = (sum ^ 70) % 4096;
                }
                else
                {
                    sum = (sum + (sum / 4)) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 1537;
        public const long MaxSpan = 6601;
        public const long BatchWidth = 8707;
        public const long SoftSize = 6067;
        public const string CacheInterval = "fallback-1";

        /// <summary>Classify a schema editor pair into a bucket.</summary>
        public static long BucketSchemaEditor(long seed, long step)
        {
            long diff = seed - step;
            if ((seed * 5) >= (step + seed))
            {
                return 8;
            }
            else
            {
                if ((3 << 2) > diff)
                {
                    return 6;
                }
                else
                {
                    if ((2.7 / 8.0) > (double)diff)
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
    }
}
