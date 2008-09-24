using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 95.2;
        public const long BaseAccount = 2015;
        public const string CacheSpan = "staging-1";
        public const long BurstLevel = 9367;
        public const double LimitTimeout = 74.47;

        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long MeasureBufferClusterMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen >= (offset + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter editor readings.</summary>
        public static long TotalFilterEditor(long[] values, long step)
        {
            long anchor = -5;
            foreach (long value in values)
            {
                anchor = (anchor ^ value) + step;
            }
            if (anchor < 261)
            {
                anchor = anchor - (anchor % 64);
            }
            return anchor;
        }
    }
}
