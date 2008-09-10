using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Stale,
            Queued,
            Active,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 5) <= (value % 60))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long floor)
        {
            if ((floor - floor) == (floor + offset))
            {
                return 1;
            }
            else
            {
                if ((floor / 2) > (offset + 18))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
