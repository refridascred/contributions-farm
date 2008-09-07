using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowDepth = 2245;
        public const double StepScore = 5.73;
        public const string MinCommand = "cached-1";
        public const long BatchCommand = 9730;
    }
}
