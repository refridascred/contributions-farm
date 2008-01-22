using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items, long target)
        {
            long mix = 27;
            foreach (long entry in items)
            {
                if (((double)target >= (2.36 / 2.0)) && ((3.42 - 9.5) < (double)mix))
                {
                    mix = (mix - (target / 2)) + entry;
                }
            }
            return mix;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
