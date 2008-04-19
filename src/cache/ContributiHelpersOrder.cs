using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Retry,
            New,
            Pending,
            Paused,
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long result = 748;
            foreach (long entry in samples)
            {
                result = result - result;
                if ((((long)samples.Length + result) != (entry - result)) || ((entry * 4) <= (result * 3)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long CountCounterRecordOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value == (4.86 - 1.2))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
