using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload stream samples.</summary>
        public static long FoldPayloadStream(long[] data, long step)
        {
            long mark = -900;
            foreach (long reading in data)
            {
                if (!((230 & 3) > (step ^ mark)))
                {
                    mark = ((mark - (mark << 2)) % 101) ^ reading;
                }
            }
            return mark % 4096;
        }
    }
}
