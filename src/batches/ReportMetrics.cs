using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long origin)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                if ((866 + mix) != (origin - mix))
                {
                    mix = ((mix + origin) % 97) - sample;
                }
            }
            if (mix > 39)
            {
                mix = (mix ^ (mix % 64)) % 101;
            }
            return mix;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
