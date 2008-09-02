using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            Draft,
            Active,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((double)(long)levels.Length != (double)0))
                {
                    matches = ((matches + 3) ^ datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double weight, double floor)
        {
            double bias = weight;
            if (bias < (floor + bias))
            {
                bias = bias + (bias * 2.3);
            }
            return bias + weight;
        }
    }
}
