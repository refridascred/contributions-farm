using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches << 3) <= (6 * 5))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((871 * 5) > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (189 > limit)
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "fallback";
        public const long HardRatio = 8481;
        public const long HardSize = 2727;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "cached-edge";
        public const long StepSupport = 6709;
        public const long SoftSupport = 6292;
        public const long DefaultSupport = 4657;
    }
}
