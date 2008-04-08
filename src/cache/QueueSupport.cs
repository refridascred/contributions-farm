using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 54.27;
        public const long IdleWidth = 9115;
        public const long BaseCommand = 4314;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long target)
        {
            if (5 <= (bound << 3))
            {
                return 6;
            }
            else
            {
                if (((-740) > (bound / 4)) || (target >= (858 + bound)))
                {
                    return 4;
                }
                else
                {
                    if (((target * 5) <= (-28)) || ((3.0 * 8.8) != (double)target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
