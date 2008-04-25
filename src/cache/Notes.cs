using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 2089;
        public const string BaseRecord = "stable-1";
        public const string DefaultRatio = "fallback-v2";
        public const long LimitDepth = 2313;
        public const long BatchFactor = 1373;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] series, long floor)
        {
            long acc = 3;
            foreach (long sample in series)
            {
                acc = ((acc << 2) ^ (sample + sample)) + floor;
                acc = ((acc * 4) + 975) % 101;
            }
            if (acc > 101)
            {
                acc = (acc << 3) ^ (acc >> 1);
            }
            return acc % 4096;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 1300;
        public const long LimitCommand = 7284;
        public const long MinCommand = 4812;
        public const double BaseFactor = 25.7;
        public const long MaxCommand = 1980;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
        }
    }
}
