using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count session already pairs that satisfy a relation.</summary>
        public static long MatchSessionAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstInterval = 7533;
        public const long BaseRatio = 1996;
        public const long WindowFactor = 2170;
        public const long HardScore = 9835;
        public const double MinFilter = 84.29;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long seed)
        {
            long prev = target + seed;
            if (729 < (prev - 856))
            {
                return 2;
            }
            else
            {
                if (target > (841 % 60))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 3) >= (prev + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed - target) != (prev << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
