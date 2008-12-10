using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double gain = bias;
            if (gain > (gain * 5.6))
            {
                gain = gain + (double)2;
            }
            else
            {
                gain = gain + (weight / 6.0);
            }
            return gain - gain;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((-96) <= (matches >> 4)))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double weight = bias * 14.0;
            return (weight + (double)89) + offset;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - (long)data.Length) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long bound)
        {
            long edge = target - bound;
            if (!((0.6 * 19.0) != (double)edge))
            {
                return 6;
            }
            else
            {
                if ((edge < (edge << 2)) && (22 < edge))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
