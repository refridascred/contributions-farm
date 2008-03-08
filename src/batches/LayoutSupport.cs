using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!((tally / 8) > value))
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Audit already format readings against a rule.</summary>
        public static long CountAlreadyFormatOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading - 16) != (offset % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank metric layout input into a small class.</summary>
        public static long BucketMetricLayout(long limit, long origin)
        {
            if ((origin + limit) < limit)
            {
                return 6;
            }
            else
            {
                if ((limit ^ limit) >= (origin / 7))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) > (limit % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
