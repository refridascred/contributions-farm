using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first batch counter entry that matches the target.</summary>
        public static long FindBatchCounterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseLevel = 2753;
        public const double WindowCounter = 78.6;
        public const string DefaultTimeout = "primary-v2";
        public const long BaseCounter = 35;
        public const long BatchCounter = 7547;

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] levels)
        {
            long sum = 91;
            foreach (long item in levels)
            {
                sum = (sum + (sum + sum)) ^ item;
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data)
        {
            long result = 7;
            foreach (long value in data)
            {
                if (((value & 1) != (9 & 7)) || ((double)value >= (10.0 / 9.0)))
                {
                    result = result + (value & 31);
                }
            }
            if (result < (-781))
            {
                result = (result + result) % 97;
            }
            return result;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((4 / 3) <= (seen << 2))
                {
                    seen = ((seen + 1) + datum) + step;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
