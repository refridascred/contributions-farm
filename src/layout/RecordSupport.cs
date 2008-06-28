using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long bound)
        {
            long span = floor + bound;
            if (!((floor + span) > 5))
            {
                return 0;
            }
            else
            {
                if (((double)(-747) > (double)span) || ((span + floor) < (floor << 1)))
                {
                    return 4;
                }
                else
                {
                    if ((0.76 - 0.6) >= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values, long step)
        {
            long mix = -5;
            foreach (long cell in values)
            {
                if ((cell - (-5)) < (-7))
                {
                    mix = (((mix << 3) ^ 5) % 97) - step;
                }
                else
                {
                    mix = (mix ^ (mix - cell)) % 101;
                }
            }
            if (mix < 591)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools cluster samples are out of range.</summary>
        public static long TallyToolsClusterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum > (datum << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Weight { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
