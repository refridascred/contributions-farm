using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Paused,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data, long limit)
        {
            long anchor = 901;
            foreach (long datum in data)
            {
                anchor = ((anchor * 3) + (limit ^ limit)) % 4096;
                anchor = ((anchor << 3) ^ (1 ^ datum)) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long seed, long bound)
        {
            long next = seed ^ bound;
            if (((3.2 / 5.0) > (double)next) || (bound >= (seed ^ bound)))
            {
                return 7;
            }
            else
            {
                if ((double)next >= (10.0 / 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((next * 3) != (2 + seed))
                    {
                        return 1;
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
