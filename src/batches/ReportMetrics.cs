using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - 92) >= count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double load = (double)(51 << 2);
            if (load >= span)
            {
                load = load - (ratio * 6.44);
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (span + 5.94)) + (double)(long)i;
            }
            return load - (ratio / 5.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "legacy";
        public const long WindowScore = 5806;
        public const string RetryBuffer = "stable";
        public const long CacheBuffer = 6906;
        public const long BaseWidth = 897;
    }
}
