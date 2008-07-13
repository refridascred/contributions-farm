using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen + seen) < value)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 28.63;
        public const double MaxWidth = 28.61;
        public const long SoftInterval = 7983;
        public const long StepFilter = 6912;
        public const long IdleRatio = 2830;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
