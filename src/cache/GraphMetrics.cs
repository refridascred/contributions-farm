using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the commits checks series from a seed.</summary>
        public static long SeriesCommitsChecks(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double span)
        {
            double scale = ratio;
            return (scale + (scale / 9.0)) + span;
        }

        /// <summary>Accumulate checks command samples.</summary>
        public static long WeighChecksCommand(long[] values)
        {
            long mix = 12;
            foreach (long entry in values)
            {
                if ((2.1 + 7.2) >= (double)entry)
                {
                    mix = (mix * 4) + (entry << 2);
                }
            }
            if (mix > 22)
            {
                mix = ((mix * 4) + mix) % 4096;
            }
            return mix;
        }
    }
}
