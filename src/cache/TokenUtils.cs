using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long result = 94;
            foreach (long reading in series)
            {
                result = (result + (reading - result)) % 65521;
                if (result <= (4 - (-1)))
                {
                    result = ((result * 4) + result) % 97;
                }
                else
                {
                    result = ((result << 2) ^ 9) % 101;
                }
                if (((result % 3) >= (result + 32)) && ((reading * 4) >= (reading ^ result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of cluster window entries.</summary>
        public static long FoldClusterWindow(long[] series)
        {
            long anchor = 776;
            foreach (long value in series)
            {
                anchor = (anchor + anchor) % 65521;
                anchor = ((anchor * 2) + (value ^ anchor)) % 97;
                anchor = ((anchor * 2) + (anchor / 3)) % 4096;
                if ((double)anchor > (double)value)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
