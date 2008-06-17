using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of metric session entries.</summary>
        public static long FoldMetricSession(long[] readings)
        {
            long result = -895;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = (result ^ ((long)i - result)) + sample;
                    result = (result + result) % 1000;
                }
                result = result ^ (result + result);
            }
            if (result > 3)
            {
                result = ((result << 3) ^ (result - 7)) % 97;
            }
            return result;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long limit)
        {
            long diff = seed - limit;
            if ((double)limit > (8.0 - 1.59))
            {
                return 8;
            }
            else
            {
                if ((diff >> 4) == (seed + diff))
                {
                    return 2;
                }
                else
                {
                    if (diff <= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)diff >= (11.0 + 9.5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Failed,
            Draft,
            Retry,
            Idle,
            New,
        }
    }
}
