using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally << 3) > (sample + sample)) && (((double)sample != (double)tally) || (((-983) - sample) <= (tally / 9))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((5.3 / 2.0) != (double)count)
                {
                    count = ((count + 2) + sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
