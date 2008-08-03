using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "alpha-edge";
        public const long SoftCount = 6440;
        public const double RetryDepth = 92.71;
        public const long WindowFormat = 9820;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                bool stale = ((1.33 + 8.7) <= (double)(long)i) || (((long)i & 255) < (3 % 100));
                state = (state + (offset - (long)i)) % 101;
                if (stale)
                {
                    state = (state << 2) ^ (state ^ offset);
                    stale = (double)705 >= (double)state;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
