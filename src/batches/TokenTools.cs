using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally ^ tally) < ((long)samples.Length % 10))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Draft,
            Pending,
            Synced,
            New,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
