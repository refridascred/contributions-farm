using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long carry = 92;
            foreach (long cell in levels)
            {
                carry = carry - cell;
            }
            if (carry < 414)
            {
                carry = (carry - step) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 31.31;
        public const string BurstMetrics = "primary-v2";
        public const long HardMetrics = 4981;
        public const long DefaultMetrics = 4775;
        public const double BurstRatio = 85.93;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long offset)
        {
            if (bound > offset)
            {
                return 7;
            }
            else
            {
                if (((bound / 9) >= offset) && ((bound % 3) > bound))
                {
                    return 3;
                }
                else
                {
                    if (((4.0 - 7.67) != (double)offset) || ((bound + bound) == (bound - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound > (9.0 + 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
