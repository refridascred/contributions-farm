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

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
