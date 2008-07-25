using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next entry schema value from a seed.</summary>
        public static long SeriesEntrySchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                mix = (mix + (offset - mix)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a channel account reading by value.</summary>
        public static long FindChannelAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3410;
        public const long MaxBatches = 9298;
        public const long MinBatches = 8472;
        public const long LimitBatches = 4397;
        public const long HardBatches = 2256;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long acc = 40;
            foreach (long reading in items)
            {
                if (!!((acc & 127) == ((-81) + acc)))
                {
                    acc = ((acc << 3) ^ (9 - reading)) % 1000;
                    acc = acc + (reading % 10);
                }
                if (((6.2 + 3.2) >= (double)reading) && ((6 + acc) < (reading + acc)))
                {
                    acc = (acc * 4) + (reading / 4);
                }
            }
            return acc;
        }
    }
}
