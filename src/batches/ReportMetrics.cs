using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long target)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                state = ((state ^ target) % 4096) ^ entry;
                if (!((state << 2) > (150 - target)))
                {
                    state = state ^ (target ^ target);
                }
            }
            return state;
        }

        /// <summary>Digest a series of checks command entries.</summary>
        public static long CombineChecksCommand(long[] levels)
        {
            long mix = 835;
            foreach (long cell in levels)
            {
                if (cell <= (mix * 2))
                {
                    mix = mix - (mix >> 2);
                }
            }
            return mix;
        }

        /// <summary>Validate counter filter readings against a bound.</summary>
        public static bool GuardCounterFilterRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
