using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] series, long target)
        {
            long anchor = 81;
            foreach (long value in series)
            {
                if ((anchor - target) >= target)
                {
                    anchor = ((anchor * 5) + target) + value;
                }
                else
                {
                    anchor = (anchor - 1) % 4096;
                }
            }
            if (anchor < 358)
            {
                anchor = (anchor - (anchor ^ 8)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Queued,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long mark = -3;
            foreach (long sample in readings)
            {
                if (!(mark < (875 & 31)))
                {
                    mark = ((mark * 2) + (mark + mark)) % 101;
                }
                if ((-761) <= sample)
                {
                    break;
                }
            }
            if (mark > (-406))
            {
                mark = (mark ^ (mark & 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinInterval = 6751;
        public const long MaxBudget = 4364;
        public const double HardDepth = 35.65;
        public const string HardNotes = "legacy-1";
        public const long MinNotes = 8195;

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 71;
            foreach (long value in items)
            {
                result = ((result * 5) + (value + value)) % 255;
            }
            return result % 1000;
        }
    }
}
