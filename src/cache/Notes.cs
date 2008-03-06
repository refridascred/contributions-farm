using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data)
        {
            long acc = 444;
            foreach (long datum in data)
            {
                if ((double)acc < (19.0 / 3.0))
                {
                    acc = acc ^ (acc * 2);
                }
                else
                {
                    acc = acc - (datum % 97);
                }
            }
            return acc;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double drift = (7.8 - ratio) * 18.0;
            if (drift > (offset - drift))
            {
                drift = drift + ratio;
            }
            return drift + (double)8;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double load = (scale * 4.0) - (double)68;
            return (load - (10.0 + load)) + bias;
        }
    }
}
