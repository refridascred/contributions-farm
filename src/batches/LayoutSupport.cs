using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double ratio2 = ratio;
            return (ratio2 + (ratio * 6.72)) + floor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long origin, long floor)
        {
            if ((5 < origin) && ((731 % 97) >= (floor + floor)))
            {
                return 7;
            }
            else
            {
                if ((floor ^ 5) >= floor)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin >= (8.54 + 17.0)) || ((floor << 1) < (floor >> 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin <= (origin + floor)) || ((floor / 9) >= (floor + floor)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
