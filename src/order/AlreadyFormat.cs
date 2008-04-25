using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Failed,
            Done,
            Paused,
            New,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxTimeout = 2477;
        public const long WindowFormat = 5985;
        public const long WindowSize = 8732;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count + 878) >= (bound << 3)) || ((8 % 8) > (count + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < (5.78 / 2.0))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
