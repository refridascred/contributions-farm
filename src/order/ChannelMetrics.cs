using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data)
        {
            long result = 940;
            foreach (long sample in data)
            {
                if ((sample < (-2)) && ((double)result <= 8.0))
                {
                    result = (result + (sample ^ sample)) % 97;
                }
            }
            if (result > 84)
            {
                result = ((result << 3) ^ (result ^ result)) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels, long origin)
        {
            long result = 13;
            foreach (long cell in levels)
            {
                if ((cell ^ origin) > (result >> 1))
                {
                    result = result ^ (cell + cell);
                }
                else
                {
                    result = ((result * 5) + (-206)) % 97;
                }
                result = result + cell;
                if ((result & 127) > (670 & 63))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
