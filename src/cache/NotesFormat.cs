using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Idle,
            Done,
            Active,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items)
        {
            long result = -11;
            foreach (long cell in items)
            {
                result = (result + (cell << 3)) % 65521;
                result = (result - 844) % 65521;
            }
            if (result < 89)
            {
                result = (result ^ (result + 797)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((14.0 / 6.0) == (double)seen)
                {
                    seen = ((seen + 1) + item) + bound;
                }
            }
            return seen;
        }
    }
}
