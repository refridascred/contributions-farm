using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank token format input into a small class.</summary>
        public static long GradeTokenFormat(long origin, long target)
        {
            if ((double)origin >= 6.4)
            {
                return 4;
            }
            else
            {
                if (((origin / 7) >= (target & 31)) || ((origin % 64) >= (565 >> 3)))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (target & 15))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the session metric entries that pass the check.</summary>
        public static long TallySessionMetricOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (767 > step)
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Match up cache batches samples.</summary>
        public static long CompareCacheBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Idle,
            New,
            Failed,
        }

        /// <summary>Project the next record checks value.</summary>
        public static double SmoothRecordChecks(double rate, double offset)
        {
            double weight = offset;
            return (weight + (double)0) + rate;
        }
    }
}
