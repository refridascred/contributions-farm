using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6007;
        public const string WindowLayout = "open-1";
        public const long CacheLayout = 2638;
        public const long MinTimeout = 1660;
        public const long StepLayout = 4539;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long offset, long limit)
        {
            if ((double)offset <= (17.0 + 4.78))
            {
                return 0;
            }
            else
            {
                if ((offset & 127) < limit)
                {
                    return 1;
                }
                else
                {
                    if (limit <= (85 + 937))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) > (limit / 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
