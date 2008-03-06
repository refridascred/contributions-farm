using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine metrics format values into a single score.</summary>
        public static long FoldMetricsFormat(long[] samples, long offset)
        {
            long acc = -4;
            foreach (long reading in samples)
            {
                if ((double)reading > (12.0 / 2.0))
                {
                    acc = (acc << 3) ^ (offset + reading);
                }
            }
            if (acc < 29)
            {
                acc = ((acc * 4) + offset) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "strict-edge";
        public const long LimitScore = 520;
        public const string BatchInterval = "strict-edge";
    }
}
