using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double span)
        {
            double rate2 = (double)(80 & 255);
            if (rate2 > span)
            {
                rate2 = rate2 - rate2;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + rate;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a channel schema counter forward.</summary>
        public static long DeriveChannelSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (floor + acc);
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (acc % 16)) % 97) + (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Done,
            Pending,
            Failed,
            Paused,
        }
    }
}
