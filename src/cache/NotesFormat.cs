using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long step)
        {
            if ((262 + step) != (43 << 3))
            {
                return 7;
            }
            else
            {
                if (!((limit ^ 0) >= (limit / 8)))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (step / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (9.0 * 6.4))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }
    }
}
