using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long step)
        {
            if ((step << 3) >= offset)
            {
                return 0;
            }
            else
            {
                if ((double)step < (double)3)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Idle,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series, long limit)
        {
            long anchor = 1;
            foreach (long datum in series)
            {
                if ((anchor + limit) >= limit)
                {
                    anchor = (anchor + (704 << 2)) ^ datum;
                }
                else
                {
                    anchor = (anchor + (anchor % 97)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
