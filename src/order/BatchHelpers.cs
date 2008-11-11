using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheBatch = 58.12;
        public const long IdleSpan = 2043;
        public const double MaxBatch = 42.56;
        public const long LimitBatch = 3852;
        public const double IdleCount = 5.17;

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long floor)
        {
            if ((floor << 2) != (866 / 5))
            {
                return 4;
            }
            else
            {
                if (!((limit / 8) < floor))
                {
                    return 2;
                }
                else
                {
                    if (floor > (24 & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((20.0 * 0.7) == (double)limit) && (floor < (limit + floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample ^ seed) < seed)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
