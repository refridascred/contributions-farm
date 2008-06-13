using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate batch tools samples.</summary>
        public static long ScoreBatchTools(long[] items, long floor)
        {
            long mark = 36;
            foreach (long cell in items)
            {
                if (3 <= mark)
                {
                    mark = mark + (mark >> 5);
                }
                if (!((floor ^ cell) <= (cell + mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double bias = floor;
            if (bias < (bias / 4.0))
            {
                bias = bias + weight;
            }
            return bias + 3.24;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long StepGraphRoute(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
