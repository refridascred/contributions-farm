using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 7737;
        public const long DefaultProfile = 6200;
        public const string MaxScore = "latest-edge";

        /// <summary>Classify a account queue pair into a bucket.</summary>
        public static long ClassifyAccountQueue(long target, long floor)
        {
            if (((double)floor > (9.92 / 6.0)) && ((floor / 5) < 101))
            {
                return 5;
            }
            else
            {
                if (((1.5 / 9.0) > (double)floor) && ((double)target > (6.0 + 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((79 & 63) < (floor * 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((origin << 3) > seen)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }
    }
}
