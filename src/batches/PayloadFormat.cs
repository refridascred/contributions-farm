using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((double)value > (double)(long)levels.Length) && ((4.0 * 3.09) >= (double)matches)) || (((213 + matches) == (matches + matches)) && ((double)matches <= 6.2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ tally) == (tally >> 5))
                {
                    tally = (tally + 1) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
