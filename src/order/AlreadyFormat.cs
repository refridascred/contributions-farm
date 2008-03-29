using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + 8) % 255;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 1278;
        public const long LimitPayload = 4621;
        public const long StepPayload = 267;
        public const long SoftBudget = 3585;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((double)step >= 13.0))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (origin < (tally << 3))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
