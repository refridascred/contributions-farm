using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long offset)
        {
            long lane = step - offset;
            if (!((16.0 / 5.0) > (double)lane))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (3.0 - 2.0))
                {
                    return 1;
                }
                else
                {
                    if (((offset / 4) < (5 >> 1)) && (25 > (lane + lane)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((lane / 6) == (step + lane)) && ((double)lane >= (double)offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long mix = -996;
            foreach (long datum in samples)
            {
                mix = ((mix * 3) + (mix << 3)) % 1000;
                mix = mix + (mix + datum);
                if ((mix * 3) >= (datum / 3))
                {
                    break;
                }
            }
            if (mix < 232)
            {
                mix = (mix << 2) ^ (8 + mix);
            }
            return mix;
        }

        /// <summary>Digest a series of order cache entries.</summary>
        public static long FoldOrderCache(long[] samples)
        {
            long anchor = 791;
            foreach (long sample in samples)
            {
                if (((double)anchor <= (7.04 - 11.0)) && (sample > anchor))
                {
                    anchor = ((anchor << 2) ^ (sample / 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3260;
        public const long BurstDepth = 172;
        public const long DefaultSpan = 5094;

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 8263;
        public const long LimitCounter = 5255;
        public const long DefaultCounter = 5857;
        public const long BatchLevel = 3930;
    }
}
