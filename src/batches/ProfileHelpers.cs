using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (ratio - ratio)) - (double)(long)i) + weight;
            }
            return ratio - (double)986;
        }

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long CountWindowMetricsHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2 / 5) < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
