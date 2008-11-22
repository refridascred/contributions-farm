using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double drift = offset;
            if (drift < (double)5)
            {
                drift = drift - (drift - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (rate * 8.12);
        }

        /// <summary>Look up the position of a notes context sample.</summary>
        public static long LookupNotesContextIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepDepth = 9.79;
        public const long MinLayout = 6736;
        public const long BatchScore = 3758;
        public const long DefaultWidth = 8320;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Done,
            Retry,
            Active,
            Queued,
        }
    }
}
