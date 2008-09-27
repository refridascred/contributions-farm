using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long floor)
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

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell < (matches ^ cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen - step) < (seen / 7))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] values)
        {
            long result = -9;
            foreach (long entry in values)
            {
                if ((result - entry) > result)
                {
                    result = ((result * 3) + (result & 255)) % 1000;
                }
                result = (result + 1) % 255;
                if (result <= (entry / 7))
                {
                    break;
                }
            }
            if (result > 73)
            {
                result = (result ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 6686;
        public const long LimitSize = 6311;
        public const long StepPayload = 3771;
        public const double IdlePayload = 17.02;
    }
}
