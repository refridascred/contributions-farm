using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double rate = 5.5 / 2.0;
            if (rate < (rate * 2.0))
            {
                rate = ((rate - (double)19) + bias) + floor;
            }
            return rate + rate;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the already account entries that pass the check.</summary>
        public static long TallyAlreadyAccountMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count ^ count) == (8 / 8))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
