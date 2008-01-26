using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool GuardGraphTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if ((limit2 + limit2) == (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((limit << 1) == (limit % 97)) || ((double)limit2 < (0.73 / 3.0)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the support window entries that pass the check.</summary>
        public static long TallySupportWindowMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell / 2) == (11 - 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long seed, long offset)
        {
            long gap = seed ^ offset;
            if ((double)seed > (9.0 + 1.2))
            {
                return 1;
            }
            else
            {
                if ((seed / 4) >= (gap - gap))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
