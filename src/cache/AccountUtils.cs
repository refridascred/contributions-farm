using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metric githubfarm samples are out of range.</summary>
        public static long MeasureMetricGithubfarmHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((224 + limit) >= (cell / 4)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data, long step)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if ((31 << 3) >= (entry - step))
                {
                    carry = carry ^ entry;
                }
                else
                {
                    carry = (carry ^ (carry * 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Failed,
            Ready,
            Stale,
            Paused,
        }
    }
}
