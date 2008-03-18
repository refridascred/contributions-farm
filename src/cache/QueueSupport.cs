using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of tools contributi entries.</summary>
        public static long WeighToolsContributi(long[] levels)
        {
            long acc = 192;
            foreach (long reading in levels)
            {
                if ((14.0 * 7.03) > (double)reading)
                {
                    acc = acc + ((-9) + acc);
                }
                else
                {
                    acc = ((acc * 2) + (reading + 998)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if ((6.9 + 9.5) > (double)origin)
            {
                return 8;
            }
            else
            {
                if (origin >= offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
