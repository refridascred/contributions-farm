using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long limit)
        {
            long result = 6;
            foreach (long reading in samples)
            {
                if ((reading >> 3) != (result * 5))
                {
                    result = (result * 5) + (reading >> 3);
                }
                if (result <= reading)
                {
                    result = (result ^ (limit >> 3)) % 65521;
                    result = (result + reading) % 101;
                }
                result = result - reading;
            }
            return result;
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
