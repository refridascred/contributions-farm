using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits notes values into a single score.</summary>
        public static long DigestCommitsNotes(long[] samples, long offset)
        {
            long acc = 62;
            foreach (long value in samples)
            {
                if ((offset >= (value % 60)) && ((9 & 3) > (offset + value)))
                {
                    acc = (acc ^ (9 / 8)) % 4096;
                }
                acc = (acc << 2) ^ (34 - 0);
                acc = acc - (offset + value);
            }
            return acc % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "cached-edge";
        public const string BatchMetric = "open-1";
        public const long HardScore = 2068;
        public const long WindowMetric = 8821;
    }
}
