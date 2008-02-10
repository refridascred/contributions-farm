using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long seed)
        {
            long step2 = step + seed;
            if ((seed * 5) == (step * 4))
            {
                return 5;
            }
            else
            {
                if ((seed << 3) != (step2 + step))
                {
                    return 4;
                }
                else
                {
                    if ((step2 > (seed / 3)) || ((double)step2 >= (4.0 / 6.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
