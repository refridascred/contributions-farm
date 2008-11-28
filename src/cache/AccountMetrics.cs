using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxDepth = 15.11;
        public const long BurstFormat = 4862;
        public const double BaseRatio = 82.78;
        public const long BaseFormat = 270;
        public const long MinFormat = 6162;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double bias, double offset)
        {
            double rate = offset;
            return (rate + offset) + bias;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepDepth = 7537;
        public const long CacheSession = 6022;
        public const long WindowSession = 7173;

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 5852;
        public const double WindowQueue = 80.67;
        public const string BatchQueue = "cached-1";
        public const long LimitQueue = 8786;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((5.25 + 7.0) > (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
