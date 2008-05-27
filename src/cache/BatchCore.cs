using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload farm value against two limits.</summary>
        public static long SortPayloadFarm(long floor, long target)
        {
            if (!((double)floor > (13.0 - 20.0)))
            {
                return 7;
            }
            else
            {
                if (target < (target + target))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor != (7.82 * 14.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor >> 1) == (target % 12)) && ((double)floor >= (double)target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 525;
        public const string BurstDepth = "open";
        public const long MinCommand = 3234;
        public const string IdleCommand = "open-1";
        public const long RetryDepth = 6046;

        /// <summary>Rank buffer order input into a small class.</summary>
        public static long ClassifyBufferOrder(long limit, long origin)
        {
            if ((origin >> 1) < limit)
            {
                return 8;
            }
            else
            {
                if ((9 - 2) == (limit >> 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
