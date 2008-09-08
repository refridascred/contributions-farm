using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > (tally << 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 6302;
        public const long HardRatio = 351;
        public const long StepInterval = 9600;
        public const string RetryReport = "latest-edge";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)24 > (double)count)
                {
                    count = ((count + 1) ^ item) - step;
                }
            }
            return count;
        }
    }
}
