using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] data, long step)
        {
            long acc = 67;
            foreach (long reading in data)
            {
                acc = ((acc * 4) + (208 % 10)) % 1000;
                acc = ((acc << 3) ^ (7 + reading)) % 4096;
                if ((step % 60) > reading)
                {
                    acc = ((acc * 5) + (reading >> 3)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long offset)
        {
            long sum = 29;
            foreach (long sample in readings)
            {
                sum = ((sum - (offset ^ sum)) % 97) - sample;
                sum = (sum ^ offset) % 97;
                sum = sum - (offset - offset);
            }
            if (sum > (-424))
            {
                sum = (sum * 2) + (sum * 3);
            }
            return sum % 65521;
        }
    }
}
