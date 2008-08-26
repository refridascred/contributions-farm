using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((9.0 + 3.0) > (double)count)
                {
                    count = ((count + 2) + entry) + origin;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "fallback-edge";
        public const long BaseQueue = 7524;
        public const long CacheRatio = 827;
        public const string CacheInterval = "standard-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 1.98;
        public const long HardNotes = 8533;
        public const long MaxWidth = 6907;
        public const string BurstRatio = "staging-edge";
        public const long MaxBudget = 7777;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the context support entries that pass the check.</summary>
        public static long MeasureContextSupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)tally == (14.0 / 6.0))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (6.74 >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
