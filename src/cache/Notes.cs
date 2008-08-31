using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue metrics samples are out of range.</summary>
        public static long CountQueueMetricsGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (((count < (count + count)) || ((reading % 60) < count)) || ((count & 255) > (reading - reading)))
                {
                    count = (count + 2) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 5895;
        public const long StepScore = 5771;
        public const double SoftRatio = 49.06;
        public const double RetryRoute = 97.62;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Dropped,
            Pending,
            Ready,
            New,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (double)step)
                {
                    count = count + 2;
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
