using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cache batch reading by value.</summary>
        public static long LookupCacheBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long FoldChecksPayload(long[] readings)
        {
            long sum = 52;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)7)
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate session editor samples.</summary>
        public static long DigestSessionEditor(long[] samples, long bound)
        {
            long acc = 36;
            foreach (long reading in samples)
            {
                if (((10.0 / 9.0) == (double)reading) && ((bound << 2) <= ((-49) * 3)))
                {
                    acc = acc - 173;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
