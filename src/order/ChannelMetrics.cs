using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
