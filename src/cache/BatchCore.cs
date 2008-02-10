using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of support contributi readings.</summary>
        public static long TotalSupportContributi(long[] series, long target)
        {
            long result = 48;
            foreach (long reading in series)
            {
                result = (result - reading) - target;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1246;
        public const long LimitCount = 5388;
        public const long DefaultGraph = 2665;
        public const long WindowGraph = 4444;

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
