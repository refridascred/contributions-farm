using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a format editor value against two limits.</summary>
        public static long ClassifyFormatEditor(long offset, long target)
        {
            if ((target ^ 59) == (target % 97))
            {
                return 5;
            }
            else
            {
                if ((offset << 3) >= offset)
                {
                    return 2;
                }
                else
                {
                    if ((2.72 - 5.6) <= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 1) >= 15)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel stats readings against a bound.</summary>
        public static bool ValidateChannelStatsLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
