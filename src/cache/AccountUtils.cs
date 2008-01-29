using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            New,
            Locked,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultLevel = 1230;
        public const long StepSize = 9266;
        public const long BaseLevel = 5775;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen > (double)689)
                {
                    seen = ((seen + 1) ^ cell) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
