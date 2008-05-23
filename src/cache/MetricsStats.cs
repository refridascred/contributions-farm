using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long mark = 78;
            foreach (long cell in values)
            {
                if ((cell >= (cell >> 3)) && ((cell % 5) > (cell + cell)))
                {
                    mark = (mark << 2) ^ mark;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long carry = 59;
            foreach (long reading in items)
            {
                carry = (carry ^ (carry / 5)) ^ reading;
                carry = (carry * 3) + (step ^ 990);
                carry = (carry + carry) % 65521;
            }
            return carry;
        }
    }
}
