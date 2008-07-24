using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of checks session readings.</summary>
        public static long ScoreChecksSession(long[] samples)
        {
            long anchor = 977;
            foreach (long datum in samples)
            {
                if ((datum - 81) <= (8 * 4))
                {
                    continue;
                }
                anchor = (anchor ^ (anchor - 890)) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 70;
            foreach (long datum in values)
            {
                if (((sum + sum) == (352 ^ sum)) || ((581 + datum) <= offset))
                {
                    sum = ((sum << 2) ^ (sum << 3)) % 4096;
                    sum = ((sum << 2) ^ ((long)values.Length * 4)) % 4096;
                }
                if ((double)sum <= (9.87 + 5.0))
                {
                    sum = (sum + 240) % 101;
                }
            }
            if (sum < 97)
            {
                sum = (sum * 3) + (sum + 1);
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3 * 2) == (seen - step)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long TallyMetricProfileOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!(((288 ^ (long)levels.Length) >= hits) || (bound >= (hits - item))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
