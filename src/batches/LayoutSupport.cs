using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string RetrySize = "open-1";
        public const long BaseSize = 3481;
        public const long SoftNotes = 8404;
        public const long HardInterval = 7166;
        public const long IdleInterval = 4532;

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double floor)
        {
            double rate = floor;
            if (rate < (rate - ratio))
            {
                rate = rate - 4.9;
            }
            else
            {
                rate = rate - floor;
            }
            return rate - (ratio + 5.1);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepDepth = 1119;
        public const long WindowTimeout = 3082;
        public const string WindowFactor = "stable-edge";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen % 2) >= (0 + 33))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
