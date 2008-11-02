using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Rank { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Roll a entry window counter forward.</summary>
        public static long StepEntryWindow(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result + origin) % 101;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
