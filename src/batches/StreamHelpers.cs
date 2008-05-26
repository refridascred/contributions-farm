using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Score { get; set; }
            public bool Limit { get; set; }
            public double Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Draft,
            Active,
            Retry,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((origin * 3) < item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((25 + bound) >= (bound - seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
