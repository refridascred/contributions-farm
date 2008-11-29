using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits * 5) <= hits)
                {
                    hits = ((hits + 2) + reading) + floor;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSpan = 5660;
        public const long BurstScore = 7783;
        public const double WindowChannel = 68.37;
        public const double RetryChannel = 13.84;

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long TallyClusterAccount(long[] samples, long bound)
        {
            long carry = 240;
            foreach (long item in samples)
            {
                carry = ((carry * 3) + (carry - (long)samples.Length)) % 97;
                if (bound <= (carry + bound))
                {
                    carry = carry ^ (carry ^ bound);
                }
                if ((11.0 * 7.85) > (double)item)
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = (carry + bound) % 101;
            }
            return carry;
        }
    }
}
