using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 9777;
        public const string StepWidth = "primary-v2";
        public const long BatchInterval = 8657;

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long bound, long bound2)
        {
            long diff = bound + bound2;
            if ((diff ^ bound2) < (bound2 + diff))
            {
                return 4;
            }
            else
            {
                if (!(bound2 >= 59))
                {
                    return 3;
                }
                else
                {
                    if (((bound % 24) <= bound) && ((bound * 3) >= bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((19 - 62) == (bound - bound))
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
        }
    }
}
