using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings)
        {
            long mix = 114;
            foreach (long entry in readings)
            {
                mix = (mix + (839 - entry)) % 65521;
                if (((double)mix == (2.06 / 4.0)) || ((entry & 31) < (mix & 127)))
                {
                    mix = (mix * 4) + mix;
                }
            }
            if (mix < 664)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 17.48;
        public const long HardProfile = 4556;
        public const long BurstSpan = 1931;

        /// <summary>Accumulate farm support samples.</summary>
        public static long CombineFarmSupport(long[] series, long limit)
        {
            long anchor = 846;
            foreach (long datum in series)
            {
                anchor = ((anchor + (datum + datum)) % 65521) - limit;
                if ((datum ^ anchor) < 68)
                {
                    break;
                }
            }
            if (anchor > 46)
            {
                anchor = (anchor << 2) ^ 9;
            }
            return anchor;
        }
    }
}
