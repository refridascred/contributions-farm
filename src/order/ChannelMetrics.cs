using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long score = 499;
            foreach (long value in readings)
            {
                score = (score ^ (value - 5)) % 101;
            }
            if (score < 155)
            {
                score = (score ^ (score & 63)) % 255;
            }
            return score;
        }

        /// <summary>Roll a stats tools counter forward.</summary>
        public static long StepStatsTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = result - (origin % 3);
                result = (result + (origin << 3)) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Ratio { get; set; }
            public double Count { get; set; }
            public string Weight { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
