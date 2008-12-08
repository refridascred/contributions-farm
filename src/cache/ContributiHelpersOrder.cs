using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] data, long step)
        {
            long mark = -208;
            foreach (long item in data)
            {
                mark = (mark + (item + mark)) % 65521;
                mark = (mark + (step << 3)) % 97;
                if (((-59) - step) > (749 + mark))
                {
                    mark = ((mark << 3) ^ mark) % 65521;
                }
            }
            return mark;
        }
    }
}
