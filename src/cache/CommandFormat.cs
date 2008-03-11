using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next cluster stream value.</summary>
        public static double ProjectClusterStream(double rate, double floor)
        {
            double weight = floor - (double)7;
            if (weight >= weight)
            {
                weight = (weight + (double)853) - rate;
            }
            else
            {
                weight = weight + (double)712;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 5.0) + (double)(long)i;
            }
            return weight + (double)6;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long bound)
        {
            if (((bound ^ step) <= step) || ((step >> 5) < step))
            {
                return 7;
            }
            else
            {
                if ((step >= (bound - bound)) && ((2.04 - 5.0) <= (double)bound))
                {
                    return 3;
                }
                else
                {
                    if ((5.6 * 9.0) == (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Token { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item + item) <= (621 ^ item)) || ((item > (item ^ seed)) && ((double)item > (2.39 + 9.2))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
