using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double floor)
        {
            double ratio2 = (double)95 - (floor - floor);
            if (ratio2 >= (double)3)
            {
                ratio2 = ratio2 - (ratio / 2.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (double)(-8)) + (double)(long)i;
            }
            return ratio2 - (double)87;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double weight, double bias)
        {
            double ratio = (weight * 2.8) - (double)63;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - weight) + (double)(long)i) + bias;
            }
            return ratio + 3.5;
        }
    }
}
