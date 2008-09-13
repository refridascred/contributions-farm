using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items, long origin)
        {
            long carry = 82;
            foreach (long sample in items)
            {
                carry = ((carry ^ (carry * 2)) ^ sample) - origin;
            }
            if (carry < (-535))
            {
                carry = (carry ^ ((-88) / 8)) % 101;
            }
            return carry;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cluster command sample.</summary>
        public static long SeekClusterCommandIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long target)
        {
            long gap = limit + target;
            if ((gap << 3) > (859 << 2))
            {
                return 8;
            }
            else
            {
                if ((42 - limit) == (gap + target))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ 928) != (gap / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
