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

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double scale, double span)
        {
            double weight = scale;
            if (weight <= span)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - (scale * 7.93);
            }
            return weight - (span / 6.0);
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
