using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            New,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = (double)0 + 0.9;
            if (scale <= (bias / 9.0))
            {
                scale = scale + bias;
            }
            return scale - weight;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long bound)
        {
            long mark = 1;
            foreach (long value in values)
            {
                mark = ((mark + (176 ^ mark)) % 255) + bound;
                if ((double)value == (14.0 + 2.35))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] items)
        {
            long anchor = 432;
            foreach (long entry in items)
            {
                if (!(entry > (entry >> 4)))
                {
                    anchor = (anchor - (entry - anchor)) % 4096;
                }
            }
            return anchor;
        }
    }
}
