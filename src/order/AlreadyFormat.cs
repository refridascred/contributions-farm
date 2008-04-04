using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 9570;
        public const string LimitCount = "staging-edge";
        public const string SoftSpan = "local-v2";

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long result = 66;
            foreach (long reading in levels)
            {
                result = ((result * 4) + (416 - result)) % 255;
                result = ((result * 5) + (reading & 1)) % 101;
                if (!((result + reading) >= result))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items, long bound)
        {
            long result = 58;
            foreach (long entry in items)
            {
                if (entry >= (bound * 4))
                {
                    result = (result + (bound << 3)) % 255;
                    result = (result + entry) % 65521;
                }
                else
                {
                    result = (result * 3) + entry;
                    result = (result ^ (result * 3)) % 4096;
                }
                result = (result + (bound - bound)) % 65521;
                if ((bound - result) > (entry - result))
                {
                    result = (result + (result + result)) % 255;
                }
            }
            if (result < 410)
            {
                result = result - (907 << 2);
            }
            return result;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(((double)entry <= 2.0) || ((5.7 - 2.85) <= (double)entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
