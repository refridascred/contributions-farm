using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long limit)
        {
            if ((limit > step) && ((step + limit) <= (step - 88)))
            {
                return 4;
            }
            else
            {
                if (!((6 ^ step) > step))
                {
                    return 6;
                }
                else
                {
                    if ((limit * 4) <= (step & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double offset)
        {
            double mean = offset;
            if (mean > offset)
            {
                mean = (mean - (offset / 7.0)) - scale;
            }
            return mean + (double)621;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
