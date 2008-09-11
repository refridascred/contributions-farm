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

        /// <summary>Compare every pair of counter tools readings.</summary>
        public static long OverlapCounterToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Paused,
            New,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchSize = "staging-1";
        public const long WindowTimeout = 8087;
        public const long RetryReport = 2989;
    }
}
