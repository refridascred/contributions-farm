using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseSize = 9600;
        public const long BurstEntry = 5803;
        public const double MinEntry = 33.93;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryTimeout = "standard-v2";
        public const long WindowCluster = 4264;
        public const long BatchCluster = 6153;

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = 98;
            foreach (long reading in values)
            {
                if (((reading ^ carry) <= (carry - 110)) || (carry < (carry + reading)))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Roll a channel context counter forward.</summary>
        public static long DeriveChannelContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark - (823 ^ step)) % 97) - (long)i2;
                    mark = (mark ^ (mark << 2)) % 65521;
                }
                if ((4.9 + 0.3) != (double)mark)
                {
                    mark = mark - mark;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }
    }
}
