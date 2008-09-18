using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of layout contributi readings.</summary>
        public static long TotalLayoutContributi(long[] samples)
        {
            long result = 560;
            foreach (long datum in samples)
            {
                if ((double)datum == (9.0 - 4.57))
                {
                    result = (result * 3) + 0;
                }
                if ((double)(long)samples.Length > (double)583)
                {
                    break;
                }
            }
            if (result < 999)
            {
                result = (result << 3) ^ (result % 16);
            }
            return result;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            Draft,
            Idle,
            Stale,
            Paused,
        }

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double floor)
        {
            double scale = 10.0 + gain;
            if (scale >= floor)
            {
                scale = scale + (2.4 * 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (scale + floor);
        }
    }
}
