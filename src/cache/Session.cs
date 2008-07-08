using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 88.53;
        public const double BaseProfile = 78.99;
        public const double BatchProfile = 76.71;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long CountPayloadRouteGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen % 3) != (seen + offset))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Find the first metrics notes entry that matches the target.</summary>
        public static long FindMetricsNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
