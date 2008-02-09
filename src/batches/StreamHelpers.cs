using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - matches) != (item / 6))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a checks layout pair into a bucket.</summary>
        public static long GradeChecksLayout(long limit, long target)
        {
            long diff = limit - target;
            if (((limit + limit) <= (target / 9)) || ((double)4 == (double)diff))
            {
                return 2;
            }
            else
            {
                if ((diff << 1) <= ((-169) - (-545)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every contributi tools entry stays within the limit.</summary>
        public static bool GuardContributiToolsLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stats graph readings against a bound.</summary>
        public static bool ValidateStatsGraphRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
