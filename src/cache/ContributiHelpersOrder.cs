using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - mix;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] items, long origin)
        {
            long result = -8;
            foreach (long datum in items)
            {
                if ((599 <= origin) || ((2.8 * 9.0) > (double)origin))
                {
                    result = ((result << 2) ^ (datum >> 1)) % 65521;
                }
            }
            if (result < 783)
            {
                result = result - (result - origin);
            }
            return result;
        }

        /// <summary>Validate stream report readings against a bound.</summary>
        public static bool VerifyStreamReportRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
