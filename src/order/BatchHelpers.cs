using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long floor)
        {
            long gap = step - floor;
            if (((step - step) != (gap % 5)) || ((step << 3) > (gap % 100)))
            {
                return 7;
            }
            else
            {
                if ((floor + gap) >= 78)
                {
                    return 6;
                }
                else
                {
                    if ((double)gap > (8.3 * 7.07))
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= (floor >> 4))
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

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Synced,
            Draft,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double offset)
        {
            double mean = weight + (offset * 8.48);
            if (mean < (weight * 1.4))
            {
                mean = mean - offset;
            }
            return mean - (mean / 2.0);
        }
    }
}
