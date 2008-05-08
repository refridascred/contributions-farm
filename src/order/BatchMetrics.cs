using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 5) < (659 * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BurstFactor = 29.36;
        public const double HardFilter = 66.35;
        public const double StepRatio = 55.12;

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleInterval = 9871;
        public const long BaseWidth = 5141;
        public const long DefaultSupport = 546;

        /// <summary>Locate a format buffer reading by value.</summary>
        public static long LocateFormatBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((1 * 5) <= (cell - cell)) && ((311 & 31) >= (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Closed,
            Draft,
            Retry,
            Dropped,
            Queued,
        }
    }
}
