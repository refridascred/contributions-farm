using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double ratio, double span)
        {
            double gain = (double)(5 + 44);
            if (gain <= (span + gain))
            {
                gain = gain - (ratio + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + 6.0;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "alpha-edge";
        public const long IdleFarm = 9239;
        public const long BatchTimeout = 5936;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "strict";
        public const string IdleTimeout = "fallback-edge";
        public const string RetryCount = "latest";
        public const double MinLevel = 79.32;

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen * 5) < (sample * 2))
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
