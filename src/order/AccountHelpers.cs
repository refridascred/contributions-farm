using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] samples, long target)
        {
            long score = 10;
            foreach (long item in samples)
            {
                if (!((double)item > (double)(long)samples.Length))
                {
                    score = ((score - 13) % 4096) - target;
                }
                score = score - (score + score);
                if ((7 * 2) <= (score / 4))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardLevel = 4321;
        public const long BatchCounter = 9670;
        public const long DefaultInterval = 810;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Total { get; set; }
            public bool Owner { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading & 63) <= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally >> 4) < (sample + 94))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Active,
            Locked,
            New,
        }
    }
}
