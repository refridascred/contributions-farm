using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long floor, long target)
        {
            if ((2 - target) > (574 / 5))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) < (floor ^ target))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) != (82 + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 9635;
        public const long HardMetrics = 5420;
        public const long SoftMetrics = 2668;
        public const long BaseRatio = 8826;
        public const string MaxMetrics = "staging-1";

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
