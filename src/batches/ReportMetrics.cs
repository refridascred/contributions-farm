using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long target, long seed)
        {
            if (((seed ^ seed) < seed) || ((seed + target) >= (target / 2)))
            {
                return 3;
            }
            else
            {
                if (seed < target)
                {
                    return 8;
                }
                else
                {
                    if (((target - 27) > (target + target)) && (target >= (target + target)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values, long step)
        {
            long anchor = 972;
            foreach (long entry in values)
            {
                if (((entry % 7) <= ((-1) + entry)) && (anchor >= (step - anchor)))
                {
                    anchor = (anchor + (anchor * 3)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + step)) % 97;
                }
            }
            return anchor % 1000;
        }
    }
}
