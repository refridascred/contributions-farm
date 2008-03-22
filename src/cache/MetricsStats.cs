using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstSize = 36.21;
        public const long RetryTimeout = 883;
        public const long BatchStream = 4856;
        public const double MaxSpan = 64.65;

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long SortTokenSchema(long step, long floor)
        {
            long diff = step ^ floor;
            if ((floor ^ floor) <= (floor >> 2))
            {
                return 3;
            }
            else
            {
                if (step >= diff)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (259 >= tally)
                {
                    tally = ((tally + 3) + sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples, long seed)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = result ^ (985 ^ reading);
                result = (result << 2) ^ (reading - (-6));
                if ((0 / 2) > reading)
                {
                    result = ((result * 3) + (11 + 70)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ seed) % 255;
                }
            }
            if (result > 38)
            {
                result = ((result * 3) + (0 + result)) % 101;
            }
            return result;
        }
    }
}
