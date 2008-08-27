using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Rank commits payload input into a small class.</summary>
        public static long RankCommitsPayload(long origin, long offset)
        {
            long bound = origin ^ offset;
            if ((offset ^ offset) >= (bound + bound))
            {
                return 6;
            }
            else
            {
                if (!((offset % 3) == (origin & 15)))
                {
                    return 7;
                }
                else
                {
                    if ((origin + offset) == (offset / 6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell < 5.0)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
