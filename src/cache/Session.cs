using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading - tally) >= reading) && ((4.6 + 3.0) == (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long target)
        {
            if (floor > (target / 4))
            {
                return 4;
            }
            else
            {
                if ((776 + floor) > (floor >> 5))
                {
                    return 1;
                }
                else
                {
                    if (((target + floor) < (target + target)) && ((floor % 7) != (target & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(target >= (target << 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc ^ (long)i) % 97;
                acc = acc + (floor * 3);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
