using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long floor)
        {
            long diff = offset - floor;
            if (((3.6 + 0.8) != (double)floor) || (87 > (offset << 2)))
            {
                return 5;
            }
            else
            {
                if (((diff << 1) < floor) && (((-8) / 4) > (offset + floor)))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 2) > (diff + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 2) < (diff % 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "standard-1";
        public const long DefaultSchema = 1646;
        public const double IdleSchema = 9.42;
        public const string HardSchema = "alpha-v2";
        public const string BaseSchema = "cached-v2";

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
