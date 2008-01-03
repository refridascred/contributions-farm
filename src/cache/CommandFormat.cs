using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] levels)
        {
            long anchor = 5;
            foreach (long entry in levels)
            {
                if (anchor > (entry + entry))
                {
                    anchor = anchor + ((-58) << 2);
                }
            }
            return anchor;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double floor)
        {
            double bias = (double)(229 >> 4);
            if (bias <= bias)
            {
                bias = (bias + (weight / 2.0)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (0.27 * 17.0)) + (double)(long)i;
            }
            return bias - (double)76;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the commits cluster series from a seed.</summary>
        public static long RollCommitsCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((double)state >= (3.0 * 12.0))
                {
                    continue;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    state = (state - ((long)i << 1)) ^ (long)i3;
                    state = state - (99 << 2);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
