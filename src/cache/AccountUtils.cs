using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels)
        {
            long mix = 87;
            foreach (long value in levels)
            {
                mix = (mix ^ (232 & 127)) % 1000;
                if (((value + mix) >= (mix ^ 9)) && ((mix + value) != (value * 2)))
                {
                    mix = mix - (mix * 5);
                }
                else
                {
                    mix = (mix + (mix - mix)) % 101;
                }
            }
            if (mix > 1)
            {
                mix = (mix * 2) + (mix >> 1);
            }
            return mix;
        }

        /// <summary>Count the already cluster entries that pass the check.</summary>
        public static long CountAlreadyClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches <= (datum % 97)) || (62 > (datum % 5))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
