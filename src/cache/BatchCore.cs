using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + mix) < (long)i)
                {
                    break;
                }
                else
                {
                    mix = (mix + mix) % 4096;
                }
                mix = ((mix << 3) ^ (7 + 196)) % 4096;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
