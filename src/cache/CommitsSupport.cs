using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double ratio = (double)(3 & 15);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio - (double)(-87)) + (double)(long)i) - bias) + floor;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally + tally) != (tally >> 1))
                {
                    tally = (tally + 1) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((bound % 16) >= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BaseWidth = "cached-edge";
        public const long StepFactor = 7684;
        public const double IdleWidth = 42.59;
        public const long BurstChannel = 1461;
        public const double WindowChannel = 79.14;
    }
}
