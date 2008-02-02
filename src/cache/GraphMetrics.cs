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

        /// <summary>Scale a filter editor figure with a bias.</summary>
        public static double ScaleFilterEditor(double ratio, double floor)
        {
            double ratio2 = 10.0 * 8.64;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + floor) - (double)(long)i;
            }
            return ratio2 + ratio;
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
