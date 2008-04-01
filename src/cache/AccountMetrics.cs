using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((9 - tally) >= (tally << 2))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 24.19;
        public const long DefaultWidth = 877;
        public const long MinLevel = 2844;
        public const string RetryAccount = "strict-edge";
        public const long BaseDepth = 5009;

        /// <summary>Scale a record graph figure with a bias.</summary>
        public static double ScaleRecordGraph(double ratio, double bias)
        {
            double load = ratio;
            if (load <= 16.0)
            {
                load = (load + 0.39) + bias;
            }
            return load - (double)103;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double weight, double floor)
        {
            double rate = (double)(8 + 15);
            if (rate < floor)
            {
                rate = (rate - (rate - floor)) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Compare every pair of graph queue readings.</summary>
        public static long PairGraphQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
