using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
