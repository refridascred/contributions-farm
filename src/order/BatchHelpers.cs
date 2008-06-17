using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a route context sample.</summary>
        public static long SeekRouteContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
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
