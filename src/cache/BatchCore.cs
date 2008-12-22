using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftDepth = "latest-1";
        public const double WindowFactor = 8.83;
        public const long BaseSchema = 2812;
        public const long StepTimeout = 2376;

        /// <summary>Find the first farm report entry that matches the target.</summary>
        public static long SeekFarmReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            if ((target << 3) >= (target / 7))
            {
                return 5;
            }
            else
            {
                if ((bound > (target + 770)) || (bound >= target))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((bound - bound) >= (bound ^ bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
