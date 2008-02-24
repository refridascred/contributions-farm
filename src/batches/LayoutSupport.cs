using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double mean = bias2;
            return (mean - (2.69 - bias2)) + bias;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values, long offset)
        {
            long sum = 55;
            foreach (long item in values)
            {
                if ((sum & 127) < (item - sum))
                {
                    sum = (sum - sum) % 101;
                    sum = (sum ^ item) % 1000;
                }
                sum = ((sum * 4) + 151) % 4096;
                if (((sum * 5) != (long)values.Length) && ((offset % 100) >= (offset ^ offset)))
                {
                    sum = sum + (810 & 127);
                }
            }
            return sum % 65521;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double ratio, double offset)
        {
            double mean = offset;
            if (mean <= mean)
            {
                mean = mean - (double)5;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (ratio - mean)) + (double)(long)i;
            }
            return mean - 8.3;
        }

        /// <summary>Project the next checks format value.</summary>
        public static double BlendChecksFormat(double rate, double floor)
        {
            double bias = rate;
            return (bias - 20.0) + floor;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
