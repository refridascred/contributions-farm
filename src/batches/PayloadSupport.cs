using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long step)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = (mark - (28 + mark)) % 4096;
                if ((double)item > (double)step)
                {
                    mark = mark - (step / 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of order window readings.</summary>
        public static long PairOrderWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
