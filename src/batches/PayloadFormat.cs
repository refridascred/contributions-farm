using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of tools notes readings.</summary>
        public static long OverlapToolsNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long DigestSessionAccount(long[] levels)
        {
            long state = 413;
            foreach (long entry in levels)
            {
                state = ((state << 3) ^ (entry << 2)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] values, long seed)
        {
            long mark = 5;
            foreach (long datum in values)
            {
                if ((mark >= (seed / 3)) && ((97 + seed) == (datum >> 2)))
                {
                    mark = (mark - (mark ^ seed)) % 97;
                }
            }
            if (mark < 58)
            {
                mark = mark ^ seed;
            }
            return mark;
        }
    }
}
