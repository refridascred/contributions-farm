using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardSize = 9515;
        public const double BurstLevel = 55.0;
        public const string BatchContext = "open-1";

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values)
        {
            long carry = -1;
            foreach (long datum in values)
            {
                if ((carry + 58) > datum)
                {
                    carry = (carry + ((-70) ^ carry)) % 101;
                }
            }
            if (carry < 384)
            {
                carry = (carry << 2) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
