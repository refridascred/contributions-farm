using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 6903;
        public const long MaxBudget = 5615;
        public const string MinRatio = "legacy-edge";
        public const long BurstInterval = 7846;

        /// <summary>Digest a series of schema cluster entries.</summary>
        public static long TotalSchemaCluster(long[] readings, long target)
        {
            long mark = -171;
            foreach (long entry in readings)
            {
                if (350 >= (target + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long offset, long seed)
        {
            if (offset > (seed + offset))
            {
                return 7;
            }
            else
            {
                if ((seed + 8) >= seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed / 9) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed - seed) > (seed + offset))
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
    }
}
