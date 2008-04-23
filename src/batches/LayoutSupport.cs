using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first buffer command entry that matches the target.</summary>
        public static long LookupBufferCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2090;
        public const string CacheSpan = "fallback-1";
        public const long MaxLayout = 1078;
        public const long CacheWidth = 348;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Idle,
            Dropped,
            New,
            Ready,
        }
    }
}
