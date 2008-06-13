using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((3.19 / 7.0) <= (double)item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long mix = -90;
            foreach (long entry in series)
            {
                if ((1.0 / 8.0) != (double)entry)
                {
                    mix = (mix ^ (176 ^ entry)) % 1000;
                }
                else
                {
                    mix = (mix + (921 ^ entry)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double weight = floor;
            return (weight + floor) + bias;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
