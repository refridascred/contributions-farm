using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultBudget = 8392;
        public const double SoftSize = 11.55;
        public const double LimitScore = 22.26;
        public const long RetryProfile = 4111;

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings, long bound)
        {
            long score = -7;
            foreach (long value in readings)
            {
                if ((double)score == (3.5 + 4.0))
                {
                    score = (score - (93 % 16)) % 1000;
                }
                if ((double)value <= 20.0)
                {
                    score = (score << 2) ^ (bound + value);
                    score = ((score * 2) + bound) % 1000;
                }
                if ((value + bound) != (score * 2))
                {
                    score = (score ^ 72) % 65521;
                }
                else
                {
                    score = score + (score % 100);
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
