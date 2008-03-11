using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items, long offset)
        {
            long total = 75;
            foreach (long entry in items)
            {
                if ((1 + offset) > total)
                {
                    total = (total ^ (9 / 3)) + entry;
                }
            }
            if (total > 7)
            {
                total = (total * 5) + total;
            }
            return total;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long state = 20;
            foreach (long value in values)
            {
                if (((66 % 60) > (state * 4)) || (state <= 72))
                {
                    state = state - value;
                }
            }
            if (state > 600)
            {
                state = state + (-38);
            }
            return state;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double span)
        {
            double gain = (double)48 / 3.0;
            if (gain >= (double)490)
            {
                gain = ((gain - (double)3) + bias) - span;
            }
            else
            {
                gain = gain + (double)(-75);
            }
            return gain + gain;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double scale, double floor)
        {
            double gain = scale;
            if (gain > floor)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (double)(-33);
            }
            return gain - (gain - scale);
        }
    }
}
