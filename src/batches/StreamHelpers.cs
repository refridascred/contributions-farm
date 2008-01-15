using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen * 2) == (value >> 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long sum = target;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetrySize = 58.56;
        public const long DefaultQueue = 6335;
        public const long StepInterval = 5823;
        public const double BurstQueue = 44.19;

        /// <summary>Digest a series of notes format entries.</summary>
        public static long DigestNotesFormat(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                acc = acc + (value ^ acc);
            }
            if (acc > 623)
            {
                acc = acc ^ (2 ^ acc);
            }
            return acc % 1000;
        }
    }
}
