using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long seed)
        {
            long cur = step + seed;
            if ((step << 2) < cur)
            {
                return 3;
            }
            else
            {
                if (step <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((2.1 / 6.0) == (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(240 < (cur - step)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings, long offset)
        {
            long anchor = 63;
            foreach (long item in readings)
            {
                if ((anchor + anchor) == (item / 6))
                {
                    anchor = (anchor - (offset * 4)) % 1000;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor ^ (offset & 31)) % 97;
            }
            return anchor;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double ratio = offset;
            if (ratio >= offset)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (weight * 3.13)) + (double)(long)i;
            }
            return ratio + (double)523;
        }
    }
}
