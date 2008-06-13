using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((3.19 / 7.0) <= (double)item))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Limit { get; set; }
            public bool Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double weight = floor;
            return (weight + floor) + bias;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long OverlapBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next report payload value from a seed.</summary>
        public static long IterateReportPayload(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score + (long)i2) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
