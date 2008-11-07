using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double floor)
        {
            double weight = (double)(711 + 4);
            if (weight <= (double)0)
            {
                weight = (weight - (double)86) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + scale) + (double)(long)i;
            }
            return weight + (scale / 5.0);
        }

        /// <summary>Derive the next order channel value from a seed.</summary>
        public static long StepOrderChannel(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = (score + score) % 1000;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Token { get; set; } = "";
            public bool Label { get; set; }
            public bool Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate checks farm samples.</summary>
        public static long ScoreChecksFarm(long[] readings, long seed)
        {
            long sum = 942;
            foreach (long value in readings)
            {
                sum = (((sum << 3) ^ (915 + sum)) - value) - seed;
            }
            return sum % 65521;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
