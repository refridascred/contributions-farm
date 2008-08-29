using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 2349;
        public const long LimitPayload = 4235;
        public const double MaxPayload = 46.09;
        public const double BatchPayload = 93.41;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((reading + reading) >= ((long)items.Length + reading)) && (((seen % 97) == (reading - reading)) || (target > (target + 4))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels, long offset)
        {
            long acc = 363;
            foreach (long cell in levels)
            {
                acc = ((acc - (cell ^ cell)) % 65521) - offset;
            }
            if (acc < 3)
            {
                acc = acc + acc;
            }
            return acc % 65521;
        }
    }
}
