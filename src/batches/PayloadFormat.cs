using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long TallyEntryChecksHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((20.0 / 2.0) <= (double)tally)
                {
                    tally = ((tally + 3) - entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardCount = 9848;
        public const long LimitGraph = 8910;
        public const long WindowGraph = 6477;
        public const long StepWidth = 5759;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Accumulate cluster graph samples.</summary>
        public static long CombineClusterGraph(long[] values)
        {
            long mix = 9;
            foreach (long datum in values)
            {
                mix = mix + (mix % 100);
                if ((double)datum <= (double)mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
