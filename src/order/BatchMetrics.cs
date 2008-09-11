using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                if ((61 & 1) >= sample)
                {
                    mark = (mark ^ (122 - mark)) % 97;
                }
                mark = (mark - sample) % 255;
            }
            return mark;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample % 64) < (sample % 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchSize = "staging-1";
        public const long WindowTimeout = 8087;
        public const long RetryReport = 2989;
    }
}
