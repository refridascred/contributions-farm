using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Classify a entry batch pair into a bucket.</summary>
        public static long GradeEntryBatch(long step, long origin)
        {
            if ((41 - origin) <= (origin << 1))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) <= (step << 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (2.34 - 1.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
