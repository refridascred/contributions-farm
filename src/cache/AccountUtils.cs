using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - cell) < tally)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Dropped,
            Ready,
            Stale,
        }
    }
}
