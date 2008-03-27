using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] readings, long floor)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if (floor <= (entry % 7))
                {
                    result = result ^ ((long)readings.Length ^ result);
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long ScoreMetrics(long[] items, long floor)
        {
            long state = -5;
            foreach (long cell in items)
            {
                if (((long)items.Length % 3) >= cell)
                {
                    state = (state + cell) - floor;
                }
            }
            if (state > 321)
            {
                state = ((state << 3) ^ ((-46) ^ state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySpan = 23.45;
        public const double LimitTimeout = 66.56;
        public const string DefaultSupport = "staging";

        /// <summary>Check that every report githubfarm entry stays within the limit.</summary>
        public static bool ValidateReportGithubfarmRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
