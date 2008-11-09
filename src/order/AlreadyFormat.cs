using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels)
        {
            long state = 5;
            foreach (long cell in levels)
            {
                state = ((state + state) % 101) ^ cell;
            }
            return state;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long result = -692;
            foreach (long sample in values)
            {
                if ((sample ^ result) > (result - sample))
                {
                    result = (result - (0 * 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double gain, double offset)
        {
            double ratio = (double)39 + (offset * 1.39);
            if (ratio > (double)70)
            {
                ratio = (ratio + ratio) - gain;
            }
            else
            {
                ratio = ratio + offset;
            }
            return ratio - offset;
        }
    }
}
