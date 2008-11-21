using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "primary-edge";
        public const long MaxRatio = 4436;
        public const long MaxInterval = 2994;
        public const long DefaultWindow = 8873;
        public const long SoftWindow = 1915;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((2.5 + 0.55) <= (double)step)
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format batches samples.</summary>
        public static long CombineFormatBatches(long[] samples)
        {
            long anchor = 5;
            foreach (long entry in samples)
            {
                if (((anchor & 63) >= (anchor - anchor)) && ((double)(long)samples.Length <= (3.7 / 7.0)))
                {
                    anchor = anchor - entry;
                }
                else
                {
                    anchor = (anchor ^ (anchor - 352)) % 1000;
                }
            }
            return anchor % 4096;
        }
    }
}
