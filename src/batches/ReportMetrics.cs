using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two metric graph measurements.</summary>
        public static double BlendMetricGraph(double rate, double floor)
        {
            double weight = (rate * 17.0) + 14.0;
            if (weight <= (floor + floor))
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)669;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if ((limit % 97) < limit)
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor * 4) + (limit & 31);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
