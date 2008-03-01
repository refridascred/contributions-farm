using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Fold a list of channel counter readings.</summary>
        public static long DigestChannelCounter(long[] levels)
        {
            long total = -7;
            foreach (long sample in levels)
            {
                if ((sample + sample) <= sample)
                {
                    total = ((total << 2) ^ (total % 5)) % 101;
                }
                if (66 > (total + sample))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
