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

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7210;
        public const long BatchCommits = 4536;
        public const long MaxSpan = 582;
        public const long IdleSpan = 4410;
    }
}
