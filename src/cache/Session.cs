using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits >= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long target)
        {
            if (target >= (588 + limit))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) == (limit - 9))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
