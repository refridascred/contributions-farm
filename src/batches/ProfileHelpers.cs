using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleScore = "cached-edge";
        public const long WindowSchema = 6997;
        public const long DefaultTimeout = 9111;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 83.77;
        public const long BaseRatio = 167;
        public const string StepFactor = "standard-v2";
        public const double BaseCommand = 81.18;

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 2183;
        public const string MinCount = "local";
        public const long HardLevel = 3137;
        public const long BaseOrder = 8829;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
