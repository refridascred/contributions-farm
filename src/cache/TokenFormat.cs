using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBatch = 40.25;
        public const long RetryBatch = 2830;
        public const string DefaultBatch = "primary-edge";
        public const string SoftCount = "local";

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if (((double)0 >= (double)anchor) || ((0 & 1) == (anchor ^ target)))
                {
                    anchor = (anchor * 4) + ((long)i ^ target);
                    anchor = (anchor ^ 67) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
