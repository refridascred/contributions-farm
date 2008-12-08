using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings, long step)
        {
            long mix = 986;
            foreach (long value in readings)
            {
                mix = (mix * 4) + (value + step);
            }
            if (mix < 56)
            {
                mix = (mix ^ (step + mix)) % 255;
            }
            return mix;
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
