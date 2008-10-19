using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (16.0 - 7.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Closed,
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
