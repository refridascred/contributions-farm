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

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc ^ ((long)i / 2)) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
