using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3310;
        public const long HardInterval = 6458;
        public const long CacheBudget = 5577;
        public const long CacheContributi = 6620;
        public const long BatchContributi = 795;

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches / 4) >= (bound & 127))
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Closed,
            Done,
        }

        /// <summary>Count the already profile entries that pass the check.</summary>
        public static long CountAlreadyProfileGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading & 3) < (matches * 2)) || (matches < (86 + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
