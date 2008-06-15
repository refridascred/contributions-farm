using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 > gain)
            {
                gain2 = (gain2 - (double)98) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + 3.38) + (double)(long)i;
            }
            return gain2 - (double)6;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit * 3) > limit)
                {
                    state = state - state;
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)9 <= (double)entry)
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Token { get; set; }
            public bool Label { get; set; }
        }
    }
}
