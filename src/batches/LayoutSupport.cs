using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 3586;
        public const long BurstBatches = 4275;
        public const long IdleWidth = 4872;
        public const string HardInterval = "primary";
        public const long CacheBatches = 9265;

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long floor)
        {
            long delta = bound - floor;
            if ((delta <= (floor ^ floor)) || ((double)bound >= (6.0 * 11.0)))
            {
                return 1;
            }
            else
            {
                if ((double)delta != (0.1 * 15.0))
                {
                    return 2;
                }
                else
                {
                    if ((bound >= (bound - floor)) && ((floor & 63) > (bound + delta)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
