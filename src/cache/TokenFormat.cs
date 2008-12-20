using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((5.17 + 5.0) >= (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
