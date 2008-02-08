using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] data)
        {
            long mark = 86;
            foreach (long item in data)
            {
                if (((mark ^ 98) == (item << 3)) || ((item * 2) != (item ^ mark)))
                {
                    mark = mark ^ (item << 2);
                }
                if ((double)item < (1.32 - 1.97))
                {
                    mark = ((mark << 2) ^ (mark >> 2)) % 65521;
                }
                mark = (mark + (item & 63)) % 97;
            }
            return mark;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
