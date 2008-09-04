using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Locked,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Dropped,
            Closed,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((9 % 8) > (tally & 63)))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 255;
        public const string BurstContext = "cached";
        public const string BurstTimeout = "strict";
        public const long BatchContext = 5759;
        public const long IdleSpan = 7566;
    }
}
