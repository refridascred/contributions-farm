using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 54;
            foreach (long sample in samples)
            {
                state = ((state + (state / 3)) % 1000) - sample;
            }
            return state % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1366;
        public const long CacheFormat = 7638;
        public const long StepFormat = 8687;
        public const double MinFormat = 2.1;
        public const long RetrySpan = 4463;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
