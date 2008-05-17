using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long bound)
        {
            long gap = target + bound;
            if (((target >> 4) <= 69) && (gap >= (gap - gap)))
            {
                return 4;
            }
            else
            {
                if ((9.81 / 7.0) == (double)target)
                {
                    return 8;
                }
                else
                {
                    if (gap <= (68 << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Done,
            Dropped,
            Active,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long step)
        {
            long anchor = 68;
            foreach (long item in samples)
            {
                anchor = ((anchor << 3) ^ (step + item)) % 4096;
                if (6.0 >= (double)step)
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                }
            }
            if (anchor > 78)
            {
                anchor = anchor - (step << 1);
            }
            return anchor;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double ratio = (double)(55 + 6);
            if (ratio <= gain)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias - 6.7)) - (double)(long)i;
            }
            return ratio - gain;
        }
    }
}
