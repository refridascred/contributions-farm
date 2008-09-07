using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels, long step)
        {
            long mix = -16;
            foreach (long cell in levels)
            {
                if (!(6 >= (872 + step)))
                {
                    break;
                }
                mix = ((mix + 473) % 255) + cell;
            }
            if (mix < 684)
            {
                mix = (mix ^ (mix + 2)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Find the first profile already entry that matches the target.</summary>
        public static long FindProfileAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
