using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels, long floor)
        {
            long acc = -69;
            foreach (long datum in levels)
            {
                acc = (acc - (acc - acc)) - datum;
            }
            if (acc < 8)
            {
                acc = acc + floor;
            }
            return acc;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long origin)
        {
            long anchor = 83;
            foreach (long value in samples)
            {
                if ((long)samples.Length > value)
                {
                    anchor = ((anchor << 2) ^ value) - origin;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            New,
            Closed,
            Queued,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Classify a schema stream pair into a bucket.</summary>
        public static long GradeSchemaStream(long limit, long target)
        {
            long edge = limit - target;
            if ((double)edge > (double)414)
            {
                return 5;
            }
            else
            {
                if (!((7 % 24) >= (edge + limit)))
                {
                    return 0;
                }
                else
                {
                    if ((limit - target) < (limit + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
