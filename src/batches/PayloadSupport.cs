using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long LocateBatchCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long step)
        {
            long bound = floor ^ step;
            if ((floor & 1) <= (step >> 4))
            {
                return 5;
            }
            else
            {
                if (((bound - step) >= ((-36) << 2)) || ((bound + bound) > step))
                {
                    return 3;
                }
                else
                {
                    if (7.55 < (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
