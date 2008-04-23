using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Weight { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] data, long step)
        {
            long total = 1;
            foreach (long value in data)
            {
                total = ((total + value) % 255) - step;
            }
            if (total > 21)
            {
                total = ((total << 2) ^ (total - (long)data.Length)) % 65521;
            }
            return total;
        }
    }
}
