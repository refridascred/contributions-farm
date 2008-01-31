using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long total = 60;
            foreach (long cell in readings)
            {
                if ((total + cell) > cell)
                {
                    total = (total << 2) ^ (93 - total);
                }
            }
            return total;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double AdjustGraph(double scale, double offset)
        {
            double load = offset;
            if (load < (double)86)
            {
                load = (load - (double)132) - scale;
            }
            return load + offset;
        }
    }
}
