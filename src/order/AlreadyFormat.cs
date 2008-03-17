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

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
