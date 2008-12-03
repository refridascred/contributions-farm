using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if (((4 - offset) >= (offset & 15)) || ((offset / 5) < ((-218) ^ floor)))
            {
                return 4;
            }
            else
            {
                if ((double)137 > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor % 12) > 2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two queue counter measurements.</summary>
        public static double AdjustQueueCounter(double scale, double bias)
        {
            double gain = scale;
            return (gain + scale) + bias;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 10) == (item / 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public double Rank { get; set; }
        }
    }
}
