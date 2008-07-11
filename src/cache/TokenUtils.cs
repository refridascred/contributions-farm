using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a notes window pair into a bucket.</summary>
        public static long SortNotesWindow(long floor, long offset)
        {
            if ((floor + offset) < (offset + floor))
            {
                return 7;
            }
            else
            {
                if ((5.67 > (double)floor) && ((offset + floor) < (floor / 6)))
                {
                    return 0;
                }
                else
                {
                    if ((47 < (offset - offset)) && ((offset + offset) >= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double offset)
        {
            double ratio = 14.0;
            if (ratio >= weight)
            {
                ratio = (ratio - (double)89) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Active,
            Dropped,
        }
    }
}
