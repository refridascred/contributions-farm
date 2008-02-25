using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            New,
            Dropped,
        }

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long CountContributiCommitsMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((origin & 7) >= (seen - reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
