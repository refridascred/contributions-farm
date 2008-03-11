using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double scale, double floor)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
