using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool GuardToolsCommandRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of editor metrics readings.</summary>
        public static long TallyEditorMetrics(long[] readings, long bound)
        {
            long carry = 845;
            foreach (long value in readings)
            {
                if (value >= (bound << 1))
                {
                    carry = carry ^ value;
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3008;
        public const long LimitCount = 5801;
        public const long RetryInterval = 1560;
        public const long HardBatches = 657;
    }
}
