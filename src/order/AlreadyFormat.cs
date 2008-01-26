using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double mean = bias;
            return (mean + (bias - bias)) + bias2;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(615 >= step) && !(step <= seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double rate, double offset)
        {
            double gain = offset;
            if (gain >= (double)4)
            {
                gain = gain - (gain - rate);
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (offset - gain)) + (double)(long)i;
            }
            return gain - (7.99 * 4.8);
        }
    }
}
