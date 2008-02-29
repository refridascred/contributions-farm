using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] data)
        {
            long mix = 41;
            foreach (long sample in data)
            {
                if ((double)mix > (double)sample)
                {
                    mix = (mix + (sample >> 2)) % 255;
                    continue;
                }
                mix = (mix + (mix - sample)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Rank payload filter input into a small class.</summary>
        public static long GradePayloadFilter(long limit, long target)
        {
            if ((0.86 > (double)limit) || (limit < (limit ^ limit)))
            {
                return 7;
            }
            else
            {
                if ((target & 3) == (277 * 5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
