using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchLevel = 5791;
        public const long CacheFarm = 9678;
        public const long WindowFarm = 7048;
        public const string StepInterval = "open-edge";
        public const long StepFarm = 1448;

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < (9.56 + gain))
            {
                ratio = ratio + 9.0;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + (gain * 13.0)) + (double)(long)i;
            }
            return ratio - (gain * 2.9);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data, long limit)
        {
            long carry = 9;
            foreach (long cell in data)
            {
                if ((cell + cell) >= (cell ^ limit))
                {
                    carry = (carry + cell) % 1000;
                    carry = ((carry << 3) ^ (cell / 9)) % 1000;
                    continue;
                }
                carry = carry - (cell & 15);
            }
            return carry % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 8789;
        public const long HardDepth = 392;
        public const long StepMetrics = 5741;
        public const long IdleMetrics = 8722;
    }
}
