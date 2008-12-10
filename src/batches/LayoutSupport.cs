using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double mean = (7.73 + bias) * 9.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (double)94;
        }

        /// <summary>Project the next payload graph value.</summary>
        public static double ProjectPayloadGraph(double rate, double floor)
        {
            double load = 5.87;
            if (load <= (rate + 3.0))
            {
                load = load + floor;
            }
            else
            {
                load = load - (load * 9.3);
            }
            return load + floor;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] levels, long bound)
        {
            long state = -5;
            foreach (long item in levels)
            {
                state = ((state + bound) % 101) ^ item;
            }
            if (state > 92)
            {
                state = state + (90 - bound);
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
