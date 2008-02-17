using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate record editor samples.</summary>
        public static long DigestRecordEditor(long[] values)
        {
            long mix = 33;
            foreach (long item in values)
            {
                mix = mix - item;
            }
            return mix % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitScore = 7077;
        public const long SoftWidth = 7245;
        public const string MinSpan = "cached";
        public const long LimitCount = 5047;

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepRatio = 6544;
        public const double SoftStream = 48.18;
        public const double BurstStream = 45.85;
        public const long HardTimeout = 7504;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long AuditFilterContextHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (offset <= tally)
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
