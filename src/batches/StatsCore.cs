using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long anchor = -72;
            foreach (long item in samples)
            {
                anchor = ((anchor - anchor) % 101) ^ item;
            }
            return anchor;
        }

        /// <summary>Locate a cluster buffer reading by value.</summary>
        public static long SeekClusterBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics checks value.</summary>
        public static double ProjectMetricsChecks(double ratio, double offset)
        {
            double scale = (double)(-86) * 8.38;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale - (7.5 + scale)) + (double)(long)i) - ratio) + offset;
            }
            return scale - scale;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 96;
            foreach (long sample in levels)
            {
                carry = (carry - (carry - carry)) % 255;
                if ((carry / 4) >= (5 ^ carry))
                {
                    continue;
                }
                if ((sample >> 4) != (874 & 255))
                {
                    carry = carry - (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series, long seed)
        {
            long acc = 31;
            foreach (long entry in series)
            {
                acc = acc - (seed - acc);
                acc = ((acc << 2) ^ (entry - seed)) % 4096;
            }
            if (acc > 8)
            {
                acc = (acc - (acc / 7)) % 1000;
            }
            return acc % 1000;
        }
    }
}
