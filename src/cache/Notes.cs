using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count window record pairs that satisfy a relation.</summary>
        public static long OverlapWindowRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many notes format samples are out of range.</summary>
        public static long AuditNotesFormatHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally < (0.71 + 2.1))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank support stream input into a small class.</summary>
        public static long SortSupportStream(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if (floor2 > 404)
            {
                return 1;
            }
            else
            {
                if ((span * 3) >= floor2)
                {
                    return 2;
                }
                else
                {
                    if ((5.2 < (double)span) && ((floor2 >> 5) != (span ^ 898)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.25 / 2.0) > (double)floor2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 4723;
        public const long WindowFactor = 813;
        public const string CacheStats = "standard-v2";
        public const long DefaultBudget = 7704;
        public const string RetryScore = "staging-v2";
    }
}
