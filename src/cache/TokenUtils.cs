using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two githubfarm format measurements.</summary>
        public static double SmoothGithubfarmFormat(double ratio, double floor)
        {
            double mean = ratio;
            if (mean > (floor - ratio))
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean + (double)47;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean + 0.4;
        }
    }
}
