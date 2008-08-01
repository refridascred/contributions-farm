using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long limit, long offset)
        {
            long offset2 = limit - offset;
            if (offset >= 98)
            {
                return 3;
            }
            else
            {
                if ((offset2 + offset) < limit)
                {
                    return 7;
                }
                else
                {
                    if (!((offset2 / 5) != (limit << 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor batch values into a single score.</summary>
        public static long ScoreEditorBatch(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = (((result << 3) ^ result) % 101) + item;
            }
            return result % 1000;
        }
    }
}
