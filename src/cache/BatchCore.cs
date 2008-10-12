using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values, long target)
        {
            long sum = 425;
            foreach (long item in values)
            {
                sum = (sum ^ 52) % 65521;
                if ((item & 7) < (sum + sum))
                {
                    sum = sum - target;
                }
                if (item < (item + target))
                {
                    sum = (sum - (item + item)) % 4096;
                }
                if ((8 & 31) <= target)
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = sum + (sum + target);
            }
            return sum % 4096;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen % 97) == (step / 8))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long TallyStatsBatchMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches - sample) > 4)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
