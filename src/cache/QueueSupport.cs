using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] items)
        {
            long mix = 8;
            foreach (long cell in items)
            {
                mix = ((mix ^ 924) % 255) ^ cell;
            }
            if (mix > (-35))
            {
                mix = (mix + (mix & 63)) % 65521;
            }
            return mix;
        }
    }
}
