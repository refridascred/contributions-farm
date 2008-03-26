using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 2) ^ (offset + offset)) % 97;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Label { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell ^ cell) != (step >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mix = 413;
            foreach (long sample in samples)
            {
                if (!(sample > (sample << 2)))
                {
                    mix = ((mix << 3) ^ (298 ^ sample)) % 4096;
                }
                mix = ((mix * 3) + mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Find the first schema payload entry that matches the target.</summary>
        public static long FindSchemaPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
