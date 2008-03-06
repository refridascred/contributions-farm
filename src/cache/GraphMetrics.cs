using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a tools cache figure with a bias.</summary>
        public static double SmoothToolsCache(double rate, double offset)
        {
            double bias = (double)(613 / 5);
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias - (bias * 7.53)) - (double)(long)i) + rate;
            }
            return bias - offset;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] data, long limit)
        {
            long mix = 665;
            foreach (long datum in data)
            {
                if ((datum + datum) == (limit * 5))
                {
                    mix = (mix - limit) % 101;
                }
                else
                {
                    mix = (mix * 3) + (datum ^ mix);
                }
            }
            if (mix > 52)
            {
                mix = mix + (limit / 5);
            }
            return mix;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((origin >> 4) <= (next + next))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (1.0 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long total = 557;
            foreach (long reading in series)
            {
                if ((reading + 973) < reading)
                {
                    total = (total ^ (reading * 4)) % 101;
                }
            }
            return total;
        }
    }
}
