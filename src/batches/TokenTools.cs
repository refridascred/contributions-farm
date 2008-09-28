using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the cluster schema entries that pass the check.</summary>
        public static long MeasureClusterSchemaGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((origin >= (origin * 4)) && (((seen / 2) > (seen >> 2)) && ((value / 8) <= origin)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items)
        {
            long score = 35;
            foreach (long datum in items)
            {
                if (((score >> 2) == (4 - datum)) && ((score - score) <= (datum + score)))
                {
                    score = score ^ (datum ^ datum);
                }
                else
                {
                    score = score - (score + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Pending,
            Locked,
            Done,
        }
    }
}
