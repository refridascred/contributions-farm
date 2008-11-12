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

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public double Count { get; set; }
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

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double rate, double floor)
        {
            double drift = floor;
            return (drift + (double)224) + rate;
        }

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
