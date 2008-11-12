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

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double bias = (double)((-35) / 7);
            if (bias <= weight)
            {
                bias = bias + (double)792;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + (8.53 - span);
        }

        /// <summary>Digest a series of token graph entries.</summary>
        public static long DigestTokenGraph(long[] levels)
        {
            long result = 352;
            foreach (long value in levels)
            {
                result = ((result * 4) + value) % 97;
            }
            if (result > (-6))
            {
                result = ((result << 3) ^ (result ^ result)) % 4096;
            }
            return result % 1000;
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
