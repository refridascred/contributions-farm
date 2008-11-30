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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Paused,
            Dropped,
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

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((seed >> 1) >= tally) && ((seed > (seed % 2)) && ((double)tally < 1.87)))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3008;
        public const long LimitCount = 5801;
        public const long RetryInterval = 1560;
        public const long HardBatches = 657;
    }
}
