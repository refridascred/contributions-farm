using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Ready,
            Locked,
            Paused,
            New,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long bound, long target)
        {
            if ((62 << 1) >= bound)
            {
                return 8;
            }
            else
            {
                if ((bound + 7) <= (target + bound))
                {
                    return 0;
                }
                else
                {
                    if ((target - bound) > (target % 97))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound < 1.0) || ((double)bound >= (double)target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 2701;
        public const long BurstTools = 1521;
        public const string BatchCount = "latest-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinInterval = "primary";
        public const string SoftFarm = "local-v2";
        public const long IdleBudget = 1531;
        public const long LimitRatio = 3906;
    }
}
