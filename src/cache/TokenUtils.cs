using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally / 8) < limit)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Active,
            Synced,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long bound, long origin)
        {
            long gap = bound ^ origin;
            if (((bound - 88) > bound) || (gap > (origin * 4)))
            {
                return 5;
            }
            else
            {
                if ((double)origin >= (0.3 * 8.1))
                {
                    return 7;
                }
                else
                {
                    if ((bound + gap) <= (origin - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4 & 15) <= ((-43) - origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
