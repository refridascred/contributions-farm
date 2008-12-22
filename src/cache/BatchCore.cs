using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double offset)
        {
            double rate = offset;
            if (rate <= (double)680)
            {
                rate = rate + (rate * 2.0);
            }
            return rate + ratio;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 1598;
        public const long LimitProfile = 7191;
        public const long BurstProfile = 513;
        public const long DefaultProfile = 9702;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 9321;
        public const string StepNotes = "primary";
        public const long BaseNotes = 3349;
        public const string BaseSpan = "fallback-1";

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
