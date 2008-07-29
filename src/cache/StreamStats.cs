using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long limit)
        {
            if (step >= limit)
            {
                return 4;
            }
            else
            {
                if (((step % 2) > (limit - limit)) && ((limit + 54) == (step - step)))
                {
                    return 5;
                }
                else
                {
                    if (step > limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Synced,
            Failed,
            Closed,
            Active,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((1.7 * 13.0) < (double)target)
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }
    }
}
