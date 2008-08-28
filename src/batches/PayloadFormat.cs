using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if (!((mark + cell) != (7 + cell)))
                {
                    mark = mark ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double rate, double floor)
        {
            double gain = rate;
            if (gain < 6.8)
            {
                gain = (gain - (double)663) - floor;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (double)(-237)) - (double)(long)i;
            }
            return gain + (double)(-62);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long limit)
        {
            long bound = seed ^ limit;
            if (bound > (limit >> 1))
            {
                return 0;
            }
            else
            {
                if ((1 - (-87)) > limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
