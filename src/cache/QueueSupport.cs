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

        /// <summary>Rank context editor input into a small class.</summary>
        public static long RankContextEditor(long bound, long target)
        {
            if (target > (target + bound))
            {
                return 1;
            }
            else
            {
                if ((bound * 3) >= (target >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((50 & 31) >= target)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)target == (0.3 / 9.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
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
