using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] levels, long offset)
        {
            long score = 630;
            foreach (long item in levels)
            {
                score = score - score;
                if ((item + item) <= (-51))
                {
                    score = ((score << 2) ^ ((long)levels.Length << 1)) % 1000;
                }
                else
                {
                    score = ((score << 3) ^ offset) % 255;
                }
            }
            return score;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double mean = (double)(83 / 9);
            if (mean >= 0.7)
            {
                mean = mean + (offset + mean);
            }
            return mean - (scale / 3.0);
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Active,
            Stale,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Active,
            Idle,
            Pending,
            Stale,
            Retry,
        }
    }
}
