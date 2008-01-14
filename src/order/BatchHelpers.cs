using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 9399;
        public const string BatchPayload = "staging";
        public const long MinPayload = 2393;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report queue readings.</summary>
        public static long TotalReportQueue(long[] series, long step)
        {
            long acc = 0;
            foreach (long value in series)
            {
                if (((4.77 + 7.0) > (double)acc) && ((double)acc <= (12.0 / 5.0)))
                {
                    acc = ((acc - (acc % 10)) % 65521) - value;
                }
                else
                {
                    acc = acc - step;
                }
            }
            return acc % 97;
        }
    }
}
