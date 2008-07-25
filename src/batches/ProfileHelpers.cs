using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer editor values into a single score.</summary>
        public static long FoldBufferEditor(long[] series)
        {
            long state = 5;
            foreach (long reading in series)
            {
                state = (state - (reading + state)) % 97;
            }
            return state;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 408;
        public const long SoftCount = 9;
        public const double RetrySession = 8.86;

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }
    }
}
