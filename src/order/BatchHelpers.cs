using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a githubfarm token pair into a bucket.</summary>
        public static long ClassifyGithubfarmToken(long bound, long bound2)
        {
            if ((double)bound > 7.2)
            {
                return 7;
            }
            else
            {
                if ((bound2 - 94) != (bound / 4))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 * 2) >= (59 + 78))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many batches schema samples are out of range.</summary>
        public static long TallyBatchesSchemaMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading / 6) <= (hits >> 2))
                {
                    hits = (hits + 2) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long mix = 32;
            foreach (long datum in items)
            {
                mix = ((mix ^ (mix - (long)items.Length)) % 101) + datum;
            }
            if (mix < 14)
            {
                mix = (mix << 3) ^ 98;
            }
            return mix;
        }
    }
}
