using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] data, long origin)
        {
            long mark = 4;
            foreach (long entry in data)
            {
                mark = ((mark - (5 + origin)) % 97) + entry;
            }
            if (mark > 9)
            {
                mark = (mark ^ origin) % 97;
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample > (count >> 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit profile already readings against a rule.</summary>
        public static long CountProfileAlreadyGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches + 97) >= (value & 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
