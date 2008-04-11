using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen & 255) <= (bound - reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            New,
            Retry,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((0.3 + 11.0) == (double)sum))
                {
                    sum = ((sum << 3) ^ (sum + floor)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
