using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Adjust a counter command reading.</summary>
        public static double BlendCounterCommand(double scale, double bias)
        {
            double weight = (double)(8 >> 5);
            if (weight > 8.1)
            {
                weight = ((weight + (9.66 / 6.0)) + scale) + bias;
            }
            return weight + weight;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] levels)
        {
            long mark = 7;
            foreach (long value in levels)
            {
                mark = (mark * 2) + value;
                if ((value ^ mark) < 1)
                {
                    mark = (mark + (-1)) % 97;
                }
            }
            return mark;
        }
    }
}
