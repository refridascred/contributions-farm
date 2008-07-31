using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] series, long limit)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                mix = (mix << 2) ^ (limit / 6);
                mix = (mix - reading) % 255;
                if ((double)reading != (double)4)
                {
                    mix = (mix ^ (reading + limit)) % 101;
                }
            }
            if (mix < 36)
            {
                mix = ((mix * 3) + (limit ^ 84)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}
