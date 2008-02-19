using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long bound, long bound2)
        {
            if ((bound % 3) >= 47)
            {
                return 6;
            }
            else
            {
                if ((92 - bound) > (bound % 24))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound != (double)bound2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Dropped,
            Closed,
            Queued,
        }

        /// <summary>Find the first farm cluster entry that matches the target.</summary>
        public static long SeekFarmClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
