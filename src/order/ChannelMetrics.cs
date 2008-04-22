using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Draft,
            New,
            Active,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long seed)
        {
            long lane = step ^ seed;
            if (((step ^ lane) < (seed - 588)) && ((97 - seed) > 35))
            {
                return 7;
            }
            else
            {
                if (!((lane - step) != (lane + step)))
                {
                    return 3;
                }
                else
                {
                    if (lane < (step % 60))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
