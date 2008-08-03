using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a schema entry value against two limits.</summary>
        public static long GradeSchemaEntry(long bound, long origin)
        {
            long span = bound - origin;
            if (bound >= origin)
            {
                return 1;
            }
            else
            {
                if ((3.1 - 15.0) >= (double)span)
                {
                    return 8;
                }
                else
                {
                    if (((bound >> 1) <= ((-12) + origin)) && ((double)bound == (11.0 * 0.45)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits / 3) >= sample) && ((3 + sample) <= (hits & 15)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
