using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items, long bound)
        {
            long result = 177;
            foreach (long item in items)
            {
                if ((bound >= (bound + (-333))) && (960 < (bound * 4)))
                {
                    result = ((result + (2 / 7)) % 4096) - item;
                }
                if ((bound - result) < result)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Pending,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Measure how many stats already samples are out of range.</summary>
        public static long CountStatsAlreadyOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - seen) > (reading / 6))
                {
                    seen = (seen + 2) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
