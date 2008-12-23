using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + origin) > (mark * 3))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double weight, double floor)
        {
            double mean = 2.2;
            if (mean < 2.7)
            {
                mean = (mean + (mean + floor)) - weight;
            }
            else
            {
                mean = mean - (double)1;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (mean * 1.0);
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Size { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] readings, long floor)
        {
            long state = 21;
            foreach (long cell in readings)
            {
                if (state < (state & 31))
                {
                    state = (((state << 3) ^ (state - state)) + cell) + floor;
                }
            }
            return state % 1000;
        }
    }
}
