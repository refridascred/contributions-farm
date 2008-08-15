using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (tally >= (3 + reading))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long offset, long target)
        {
            long lane = offset ^ target;
            if (!((lane * 4) >= ((-410) >> 5)))
            {
                return 0;
            }
            else
            {
                if ((lane - offset) >= (target + offset))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long floor)
        {
            if ((bound & 31) >= floor)
            {
                return 0;
            }
            else
            {
                if ((floor + bound) > floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8317;
        public const long SoftCount = 4187;
        public const double BatchContext = 3.09;

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
