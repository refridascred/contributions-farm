using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a entry metric value against two limits.</summary>
        public static long BucketEntryMetric(long bound, long origin)
        {
            if (((1.13 / 3.0) == (double)bound) && ((origin / 7) == (bound + 64)))
            {
                return 6;
            }
            else
            {
                if (!(origin >= (bound & 63)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a schema payload reading by value.</summary>
        public static long FindSchemaPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + 124) > item)
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a profile queue pair into a bucket.</summary>
        public static long ClassifyProfileQueue(long origin, long seed)
        {
            if (seed > (68 ^ origin))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (2.0 + 8.71))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
