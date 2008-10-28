using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] readings)
        {
            long result = 8;
            foreach (long reading in readings)
            {
                if (result >= (3 % 2))
                {
                    result = (((result * 5) + 294) % 255) + reading;
                }
            }
            return result % 4096;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long target, long seed)
        {
            long step = target - seed;
            if (step >= seed)
            {
                return 2;
            }
            else
            {
                if ((step + step) == (0 + seed))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
