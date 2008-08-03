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

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Region { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
