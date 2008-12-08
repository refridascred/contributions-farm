using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples, long origin)
        {
            long state = 1;
            foreach (long sample in samples)
            {
                state = ((state * 5) + (state - origin)) - sample;
                if (((double)origin > 9.08) && ((state + state) <= (state % 2)))
                {
                    break;
                }
            }
            return state % 97;
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
