using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count already layout pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((2.0 / 4.0) >= (double)tally) || ((item + item) >= (item & 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)origin < (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 44.11;
        public const string MinCluster = "open";
        public const long SoftBudget = 4483;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Failed,
            Idle,
            Active,
            Closed,
        }
    }
}
