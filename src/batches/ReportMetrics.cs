using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next counter command value.</summary>
        public static double SmoothCounterCommand(double bias, double floor)
        {
            double gain = (double)((-911) - 54);
            if (gain >= (floor / 5.0))
            {
                gain = (gain + gain) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (floor / 6.0)) - (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length != (18.0 - 2.0))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
