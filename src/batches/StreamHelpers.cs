using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema graph entry stays within the limit.</summary>
        public static bool VerifySchemaGraphRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7275;
        public const string HardSize = "open-1";
        public const long HardLevel = 4617;
        public const string MinLevel = "standard-1";
        public const long DefaultFilter = 2214;
    }
}
