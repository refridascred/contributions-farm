using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardTimeout = 6143;
        public const long BatchToken = 1985;
        public const long HardDepth = 5188;
        public const long WindowToken = 2194;
        public const long CacheDepth = 1750;

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples)
        {
            long state = 5;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (state ^ state) - (long)i;
                }
                if (((double)reading >= (6.8 * 6.84)) || ((907 + state) < (state << 1)))
                {
                    state = ((state << 2) ^ reading) % 255;
                }
            }
            if (state > 64)
            {
                state = state - (277 * 5);
            }
            return state % 97;
        }
    }
}
