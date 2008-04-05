using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 2505;
        public const double HardTimeout = 54.58;
        public const string WindowRecord = "open-edge";
        public const string DefaultSpan = "primary-1";
        public const double DefaultRecord = 81.47;

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((mix ^ seed) < (mix >> 5))
                {
                    mix = (mix ^ (4 + mix)) % 255;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
