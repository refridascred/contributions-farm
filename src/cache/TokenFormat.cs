using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a queue schema pair into a bucket.</summary>
        public static long BucketQueueSchema(long limit, long origin)
        {
            long edge = limit + origin;
            if (edge >= limit)
            {
                return 6;
            }
            else
            {
                if (((limit + origin) == (edge - 6)) || ((edge % 3) >= (origin & 3)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) >= (edge - limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit - 940) == (edge * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema commits entries that pass the check.</summary>
        public static long TallySchemaCommitsGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally <= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
