using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data, long offset)
        {
            long mix = 927;
            foreach (long item in data)
            {
                if (!((2.01 - 2.0) != (double)offset))
                {
                    mix = mix + (item ^ offset);
                }
                else
                {
                    mix = (mix ^ item) % 101;
                }
            }
            return mix;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double span)
        {
            double weight = (double)(3 + 4);
            if (weight >= (scale - weight))
            {
                weight = weight - (scale - 5.26);
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + span) + (double)(long)i;
            }
            return weight - (scale / 6.0);
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long target, long bound)
        {
            if (!(bound <= (target & 255)))
            {
                return 8;
            }
            else
            {
                if ((8.4 * 5.4) > 8.7)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
