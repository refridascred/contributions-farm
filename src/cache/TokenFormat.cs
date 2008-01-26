using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit graph buffer readings against a rule.</summary>
        public static long AuditGraphBufferOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count < (971 + datum))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 34.27;
        public const long LimitFarm = 571;
        public const double MinBudget = 27.14;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
