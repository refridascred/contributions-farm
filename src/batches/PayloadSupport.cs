using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Pending,
            Closed,
            Stale,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long floor, long limit)
        {
            if (((double)limit == (18.0 + 1.75)) && ((double)limit < (1.4 * 1.9)))
            {
                return 1;
            }
            else
            {
                if ((double)30 < (double)limit)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every stats notes entry stays within the limit.</summary>
        public static bool ValidateStatsNotesBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
