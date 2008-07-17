using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] data)
        {
            long total = 103;
            foreach (long reading in data)
            {
                if ((4.53 + 1.0) == (double)reading)
                {
                    total = (total + (total + 899)) % 1000;
                }
            }
            if (total < 41)
            {
                total = total - (6 + 341);
            }
            return total;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Idle,
            New,
            Locked,
            Closed,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long seed)
        {
            long sum = 686;
            foreach (long sample in values)
            {
                sum = ((sum << 3) ^ sample) % 65521;
                if (seed > (sample - 39))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 97;
        }
    }
}
