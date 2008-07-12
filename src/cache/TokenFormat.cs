using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Paused,
            Queued,
            Done,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample % 10) <= (tally + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
