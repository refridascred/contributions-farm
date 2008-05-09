using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a notes metrics value against two limits.</summary>
        public static long BucketNotesMetrics(long step, long bound)
        {
            if (!(3.33 <= (double)bound))
            {
                return 6;
            }
            else
            {
                if (4.5 <= (double)step)
                {
                    return 2;
                }
                else
                {
                    if (!((bound * 3) < (bound + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound == (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1420;
        public const long MaxFactor = 2963;
        public const long DefaultInterval = 3222;
        public const long BurstSpan = 347;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
