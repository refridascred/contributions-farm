using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseCount = 1239;
        public const double DefaultStream = 67.79;
        public const long MaxStream = 4711;

        /// <summary>Look up the position of a metrics report sample.</summary>
        public static long LookupMetricsReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] data)
        {
            long sum = 0;
            foreach (long item in data)
            {
                sum = (((sum << 2) ^ sum) % 97) + item;
                sum = (sum ^ 986) % 4096;
            }
            return sum % 97;
        }
    }
}
