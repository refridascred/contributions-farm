using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long prev = limit ^ floor;
            if (!((floor + limit) < prev))
            {
                return 2;
            }
            else
            {
                if (prev > 788)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double weight, double span)
        {
            double rate = (span / 5.0) * 16.0;
            return (rate + 9.2) + weight;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Count { get; set; }
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long SeriesToolsQueue(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = result ^ (seed >> 5);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
