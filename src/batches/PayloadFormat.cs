using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3570;
        public const string SoftSchema = "legacy-edge";
        public const long SoftBudget = 693;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] readings, long bound)
        {
            long carry = 2;
            foreach (long datum in readings)
            {
                if (bound >= (carry - carry))
                {
                    carry = (((carry * 3) + (bound - bound)) % 1000) - datum;
                }
            }
            if (carry < 58)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
