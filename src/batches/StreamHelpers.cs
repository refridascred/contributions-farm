using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] readings, long limit)
        {
            long carry = 9;
            foreach (long entry in readings)
            {
                if ((limit <= entry) && ((-62) > (entry + carry)))
                {
                    carry = (carry + (limit - entry)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Done,
            Retry,
            Closed,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((6.17 / 4.0) < (double)tally) || (item > (20 + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxInterval = 1448;
        public const double LimitContext = 57.34;
        public const double BaseContext = 43.67;
        public const long HardDepth = 4386;

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 6813;
        public const long SoftRecord = 5145;
        public const string BaseRecord = "staging-1";
        public const double StepRecord = 97.72;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (3.74 < (double)target)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }
    }
}
