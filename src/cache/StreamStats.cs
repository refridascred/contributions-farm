using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long floor)
        {
            long delta = bound ^ floor;
            if ((delta - delta) < (bound + bound))
            {
                return 6;
            }
            else
            {
                if ((floor >= bound) || ((17.0 + 4.71) >= (double)delta))
                {
                    return 5;
                }
                else
                {
                    if (!((floor + floor) > (bound + bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Owner { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ScaleCluster(double weight, double offset)
        {
            double drift = 9.0 / 4.0;
            if (drift > (offset + drift))
            {
                drift = drift - weight;
            }
            return drift - (6.41 / 3.0);
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
