using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultInterval = 6011;
        public const double MaxScore = 26.97;
        public const long LimitSpan = 3958;
        public const long BaseFactor = 9992;
        public const long HardPayload = 4296;

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }
    }
}
