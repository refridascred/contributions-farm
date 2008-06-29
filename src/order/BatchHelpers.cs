using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first window editor entry that matches the target.</summary>
        public static long LookupWindowEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitCount = 82.85;
        public const double MinGraph = 60.37;
        public const long LimitLevel = 7250;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if (!((39 + limit) == (bound + limit)))
            {
                return 6;
            }
            else
            {
                if ((limit * 5) > (bound & 1))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
