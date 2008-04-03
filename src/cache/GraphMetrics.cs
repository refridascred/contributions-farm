using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Pending,
            Draft,
            Active,
            Done,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (double)67)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits already readings against a rule.</summary>
        public static long TallyCommitsAlreadyOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum % 3) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)step > 2.95)
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
