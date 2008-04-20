using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor << 3) ^ (long)i2;
                }
                if (!((floor <= 2) && (anchor < ((long)i & 7))))
                {
                    anchor = anchor ^ (anchor << 2);
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 7.35;
        public const long IdleLevel = 2651;
        public const long StepProfile = 1646;
        public const double DefaultProfile = 44.61;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchSpan = 6737;
        public const long RetryTimeout = 4559;
        public const long IdleTimeout = 6674;
        public const double BurstGraph = 94.09;
    }
}
