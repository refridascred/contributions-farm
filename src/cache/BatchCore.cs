using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 2746;
        public const long MaxFactor = 9197;
        public const string HardReport = "alpha-v2";
        public const string BaseScore = "fallback-1";

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long step, long step2)
        {
            if ((step2 + step) < (step2 ^ step))
            {
                return 6;
            }
            else
            {
                if ((step2 << 1) > step2)
                {
                    return 8;
                }
                else
                {
                    if ((step - step2) > (step2 - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step > (step >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank format editor input into a small class.</summary>
        public static long BucketFormatEditor(long seed, long target)
        {
            long edge = seed ^ target;
            if ((seed * 5) >= seed)
            {
                return 7;
            }
            else
            {
                if ((edge * 4) > edge)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
