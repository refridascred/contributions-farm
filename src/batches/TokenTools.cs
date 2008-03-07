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

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
