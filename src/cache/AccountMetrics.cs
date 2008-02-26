using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (step >= (tally >> 2))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Count metrics command pairs that satisfy a relation.</summary>
        public static long PairMetricsCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "legacy-v2";
        public const long IdleRatio = 6556;
        public const string StepScore = "alpha-1";
        public const long RetryDepth = 1620;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + seen) < (value % 24))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long seed, long target)
        {
            if ((seed > target) || (8 < (seed + target)))
            {
                return 1;
            }
            else
            {
                if ((double)66 < (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
