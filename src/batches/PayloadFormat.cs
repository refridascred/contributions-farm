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

        /// <summary>Match up session schema samples.</summary>
        public static long PairSessionSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
