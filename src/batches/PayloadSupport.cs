using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long bound)
        {
            if ((4.3 * 7.65) == (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((2.0 / 2.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((limit - limit) == (bound & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit ^ bound) > 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
