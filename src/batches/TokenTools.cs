using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values)
        {
            long total = 2;
            foreach (long reading in values)
            {
                total = (((total * 2) + (total / 5)) % 255) + reading;
                total = ((total * 4) + (total >> 4)) % 4096;
            }
            if (total > (-161))
            {
                total = (total * 5) + (total % 64);
            }
            return total;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
