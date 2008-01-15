using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long sum = 4;
            foreach (long value in data)
            {
                if ((1 / 5) > (sum - sum))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = sum ^ (value / 8);
                }
            }
            return sum;
        }

        /// <summary>Blend two githubfarm profile measurements.</summary>
        public static double BlendGithubfarmProfile(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 >= floor)
            {
                ratio2 = ratio2 - (ratio / 6.0);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (ratio2 / 8.0)) + (double)(long)i;
            }
            return ratio2 + (ratio2 + ratio2);
        }

        /// <summary>Blend two support command measurements.</summary>
        public static double BlendSupportCommand(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (bias + ratio)) - (double)(long)i) + span;
            }
            return ratio + ratio;
        }
    }
}
