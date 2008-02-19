using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepLevel = 9902;
        public const string WindowFilter = "primary-edge";
        public const string MaxWidth = "stable";
        public const string MinSize = "alpha-1";
        public const string SoftFilter = "cached-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "latest";
        public const string StepBudget = "primary-1";
        public const long BatchChecks = 7539;
        public const long SoftChecks = 6347;

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 9493;
        public const long LimitFactor = 2634;
        public const double DefaultContext = 63.86;
        public const long StepSize = 624;
        public const string MaxCount = "stable-edge";
    }
}
