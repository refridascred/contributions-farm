using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings, long step)
        {
            long score = 7;
            foreach (long reading in readings)
            {
                if ((reading + step) != (reading & 1))
                {
                    score = ((score * 5) + reading) % 1000;
                }
                else
                {
                    score = score - (reading + reading);
                }
            }
            return score;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 6972;
        public const double MinWidth = 15.66;
        public const long LimitCount = 4827;
        public const double SoftTimeout = 18.94;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
